using System;

namespace Skynet.Dtos.Attributes.DynamicFields
{
    public class InstanceDynamicFieldAttribute : DynamicFieldsDtoBaseAttribute
    {
        public InstanceDynamicFieldAttribute(string name)
            : base(name)
        {
        }
    }
}