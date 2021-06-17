using System;
using System.Collections.Generic;
using System.Text;

namespace Skynet.Dtos.Role
{
    public class ClaimDto
    {
        public string Value { get; }
        public ClaimDto(string value)
        {
            Value = value;
        }
    }
}
