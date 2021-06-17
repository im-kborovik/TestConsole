using System;

namespace Skynet.Dtos.Tasks
{
    public class TaskRequestDto
    {
        public Guid TaskTypeId { get; set; }

        public Guid ApplicationId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}