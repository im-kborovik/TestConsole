using System;
using System.Collections.Generic;
using System.Linq;
using Skynet.Forms.Constants;
using Skynet.Helpers.Reflection;

namespace Skynet.Forms.Services
{
    public static class DynamicFieldTypesProvider
    {
        private static readonly Dictionary<string, Type> _commonTypes;

        static DynamicFieldTypesProvider()
        {
            _commonTypes = GetCommonTypes();
        }

        public static string GetTypeName(Type type)
        {
            if (type.IsNullable())
            {
                type = Nullable.GetUnderlyingType(type);
            }

            var (fieldTypeName, _) = _commonTypes.FirstOrDefault(q => q.Value == type);

            return string.IsNullOrEmpty(fieldTypeName) ? "string" : fieldTypeName;
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
            return new Dictionary<string, Type>()
                   {
                { CommonTypeNames.String, typeof(string) },
                { CommonTypeNames.Bool, typeof(bool) },
                { CommonTypeNames.Double, typeof(double) },
                { CommonTypeNames.Long, typeof(long) },
                { CommonTypeNames.Int, typeof(int) },
                { CommonTypeNames.Date, typeof(DateTime) },
            };
        }
    }
}