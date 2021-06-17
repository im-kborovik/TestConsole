using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Skynet.Helpers.Reflection
{
    public static class ReflectionExtensions
    {
        public static bool InheritsOrImplements(this Type child, Type parent)
        {
            var par = parent;
            return par.IsAssignableFrom(child) || InheritsOrImplementsDeep(child, ref parent);
        }

        public static bool IsNullable(this Type child)
        {
            return child.InheritsOrImplements(typeof(Nullable<>));
        }

        public static IEnumerable<PropertyInfo> GetPropertiesWithoutExclusions<T>(this Type type, IEnumerable<Expression<Func<T, object>>> excludedProperties)
        {
            return type.GetProperties()
                       .Where(x => excludedProperties.All(y => y.GetMemberExpression().Member.Name != x.Name));
        }
        
        public static MemberExpression GetMemberExpression(this LambdaExpression memberAccessLambda)
        {
            var propExpr = (MemberExpression)null;
            if (memberAccessLambda.Body is UnaryExpression unary)
            {
                propExpr = unary.Operand as MemberExpression;
            }

            if (propExpr == null)
            {
                propExpr = memberAccessLambda.Body as MemberExpression;
            }

            return propExpr;
        }

        public static bool TryGetAttribute<T>(this MemberInfo memberInfo, out T attribute, bool inherit = true)
            where T : Attribute
        {
            attribute = memberInfo.GetCustomAttribute<T>(inherit);

            return attribute != null;
        }

        /// <summary>
        ///     Makes a deep validation, e.g. does the type in question has any implementation of
        ///     ICollection&lg;gt; rather than a specific type.
        /// </summary>
        /// <param name="child"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        private static bool InheritsOrImplementsDeep(Type child, ref Type parent)
        {
            parent = ResolveGenericTypeDefinition(parent);

            var currentChild = child.IsGenericType
                ? child.GetGenericTypeDefinition()
                : child;

            while (currentChild != typeof(object))
            {
                if (parent == currentChild || ImplementsInterface(parent, currentChild))
                {
                    return true;
                }

                currentChild = currentChild.BaseType != null && currentChild.BaseType.IsGenericType
                    ? currentChild.BaseType.GetGenericTypeDefinition()
                    : currentChild.BaseType;

                if (currentChild == null)
                {
                    return false;
                }
            }

            return false;
        }

        private static bool ImplementsInterface(Type parent, Type child)
        {
            return child.GetInterfaces()
                        .Any(childInterface =>
                        {
                            var currentInterface = childInterface.IsGenericType
                                ? childInterface.GetGenericTypeDefinition()
                                : childInterface;

                            return currentInterface == parent;
                        });
        }

        private static Type ResolveGenericTypeDefinition(Type parent)
        {
            var shouldUseGenericType = !(parent.IsGenericType && parent.GetGenericTypeDefinition() != parent);

            if (parent.IsGenericType && shouldUseGenericType)
            {
                parent = parent.GetGenericTypeDefinition();
            }

            return parent;
        }
    }
}