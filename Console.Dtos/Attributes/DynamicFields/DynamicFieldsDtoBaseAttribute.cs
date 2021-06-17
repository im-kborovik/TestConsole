using System;

namespace Skynet.Dtos.Attributes.DynamicFields
{
    public abstract class DynamicFieldsDtoBaseAttribute : Attribute
    {
        protected DynamicFieldsDtoBaseAttribute(string name)
        {
            Name = !string.IsNullOrEmpty(name) ? name : throw new ArgumentException(nameof(name));
        }

        public string Name { get; }
    }
}