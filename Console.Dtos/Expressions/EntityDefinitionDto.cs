using System;
using System.Collections.Generic;

namespace Skynet.Dtos.Expressions
{
    public class EntityDefinitionDto
    {
        public EntityDefinitionDto(string name, string originalName, bool isRootEntity)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Properties = new SortedDictionary<string, string>();
            IsRootEntity = isRootEntity;
        }

        public EntityDefinitionDto(string name, IDictionary<string, string> properties, bool isRootEntity)
        {
            Name = name;
            Properties = properties;
            IsRootEntity = isRootEntity;
        }

        public string Name { get; }

        public IDictionary<string, string> Properties { get; }

        public bool IsRootEntity { get; }
    }
}