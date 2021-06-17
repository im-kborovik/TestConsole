using System;

namespace Skynet.Dtos.Attributes.DynamicFields
{
    public class RootDynamicFieldsDtoAttribute : DynamicFieldsDtoBaseAttribute
    {
        public RootDynamicFieldsDtoAttribute(string name)
            : base(name)
        {
        }
    }
}