using System;
using System.Collections.Generic;
using System.Linq;
using Skynet.Dtos.ApplyForm.Application;
using Skynet.Dtos.Attributes.DynamicFields;
using Skynet.Helpers.Reflection;

namespace Skynet.Forms.Services
{
    public class FormsDynamicFieldsService
    {
        private static readonly IReadOnlyCollection<Info> _dynamicFieldDtos;

        private static readonly Dictionary<string, Type> _commonTypes = GetCommonTypes();

        static FormsDynamicFieldsService()
        {
            _dynamicFieldDtos = GetDynamicFields();
        }

        public IReadOnlyCollection<Info> GetScheme()
        {
            return _dynamicFieldDtos;
        }

        private static Dictionary<string, Type> GetRootDynamicFieldTypes()
        {
            var result = new Dictionary<string, Type>();
            var investigatingTypeAssembly = typeof(ApplicationDto).Assembly;

            foreach (var type in investigatingTypeAssembly.GetTypes())
            {
                if (!type.TryGetAttribute<RootDynamicFieldsDtoAttribute>(out var rootAttr, false))
                {
                    continue;
                }

                result.Add(rootAttr.Name, type);
            }

            return result;
        }

        private static IReadOnlyCollection<Info> GetDynamicFields()
        {
            // const string startModelPath = "@Model";

            var result = new List<Info>();
            var rootDynamicFieldTypes = GetRootDynamicFieldTypes();

            foreach (var (rootTypeName, rootType) in rootDynamicFieldTypes)
            {
                var modelPath = rootTypeName; //GetModelPropPath(startModelPath, rootTypeName);

                AddDynamicFieldsDefinitions(rootType, rootTypeName, modelPath, result);
                AddInstanceFields(rootType, rootTypeName, modelPath, result, false);
            }

            return result;
        }

        private static void AddInstanceFields(Type parentType,
                                              string parentTypeName,
                                              string modelPath,
                                              ICollection<Info> result,
                                              bool useParentPrefix = true)
        {
            var props = parentType.GetProperties();

            foreach (var prop in props)
            {
                if (!prop.TryGetAttribute<InstanceDynamicFieldAttribute>(out var instanceDynamicFieldAttribute, false))
                {
                    continue;
                }

                var name = useParentPrefix
                    ? $"{parentTypeName} {instanceDynamicFieldAttribute.Name}"
                    : instanceDynamicFieldAttribute.Name;

                var newModelPath = GetModelPropPath(modelPath, prop.Name);
                AddDynamicFieldsDefinitions(prop.PropertyType, name, newModelPath, result);
                AddInstanceFields(prop.PropertyType, name, newModelPath, result);
            }
        }

        private static void AddDynamicFieldsDefinitions(Type dynamicFieldType, string dynamicFieldName, string modelPath, ICollection<Info> result)
        {
            var props = dynamicFieldType.GetProperties();

            foreach (var prop in props)
            {
                if (!prop.TryGetAttribute<DynamicFieldAttribute>(out _, false))
                {
                    continue;
                }

                var info = new Info
                           {
                               Title = $"{dynamicFieldName} {prop.Name}",
                               Field = GetModelPropPathEnd(modelPath, prop.Name),
                               Type = GetTypeName(prop.PropertyType)
                           };

                result.Add(info);
            }
        }

        private static string GetModelPropPath(string modelPath, string propName)
        {
            return modelPath + "." + propName;
        }

        private static string GetModelPropPathEnd(string modelPath, string propName)
        {
            return modelPath + "." + propName;
        }

        public static string GetTypeName(Type type)
        {
            if (type.IsNullable())
            {
                type = Nullable.GetUnderlyingType(type);
            }

            var (fieldTypeName, _) = _commonTypes.FirstOrDefault(q => q.Value == type);

            return string.IsNullOrWhiteSpace(fieldTypeName) ? "string" : fieldTypeName;
        }

        public static Type GetType(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }

            return _commonTypes.ContainsKey(typeName) ? _commonTypes[typeName] : null;
        }

        private static Dictionary<string, Type> GetCommonTypes()
        {
            return new()
                   {
                       {
                           CommonTypeNames.String, typeof(string)
                       },
                       {
                           CommonTypeNames.Bool, typeof(bool)
                       },
                       {
                           CommonTypeNames.Double, typeof(double)
                       },
                       {
                           CommonTypeNames.Long, typeof(long)
                       },
                       {
                           CommonTypeNames.Int, typeof(int)
                       },
                       {
                           CommonTypeNames.Date, typeof(DateTime)
                       }
                   };
        }
    }

    public static class CommonTypeNames
    {
        public const string String = "string";
        public const string Double = "double";
        public const string Bool = "bool";
        public const string Int = "int";
        public const string Long = "long";
        public const string Date = "date";
    }


    public class Info
    {
        public string Title { get; set; }

        public string Field { get; set; }

        public string Type { get; set; }
    }
}