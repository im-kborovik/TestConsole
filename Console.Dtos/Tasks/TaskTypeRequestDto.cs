using System;
using Skynet.Shared.Tasks;

namespace Skynet.Dtos.Tasks
{
    public class TaskTypeRequestDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TaskDataType DataType { get; set; }

        public Guid? TaskCategoryId { get; set; }

        public Guid? DocumentTypeId { get; set; }
    }
}