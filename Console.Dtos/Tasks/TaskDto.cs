using System;
using Skynet.Shared.Tasks;

namespace Skynet.Dtos.Tasks
{
    public class TaskDto : TaskCreateRequestDto
    {
        public Guid TaskId { get; set; }

        public string UserNote { get; set; }

        public string SubmittedText { get; set; }

        public TaskStatus Status { get; set; }

        public DateTime LastModified { get; set; }
    }
}