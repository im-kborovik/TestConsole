using System;
using System.Collections.Generic;
using System.Linq;

namespace Skynet.Dtos.Expressions
{
    public class EnumDefinitionDto
    {
        public EnumDefinitionDto(string name, IEnumerable<string> allowedValues)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            AllowedValues = allowedValues?.ToArray() ?? throw new ArgumentNullException(nameof(allowedValues));
        }

        public string Name { get; }
        
        public IReadOnlyCollection<string> AllowedValues { get; }
    }
}