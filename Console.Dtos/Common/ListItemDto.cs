using System;

namespace Skynet.Dtos.Common
{
    public sealed class ListItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
