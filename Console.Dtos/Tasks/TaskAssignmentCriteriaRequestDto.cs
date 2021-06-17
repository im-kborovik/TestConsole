using System;

namespace Skynet.Dtos.Tasks
{
    public class TaskAssignmentCriteriaRequestDto
    {
        public string Name { get; set; }
        
        public Guid? TaskTypeId { get; set; }

        public Guid? ParentCriteriaId { get; set; }

        public Guid? BaseCriteriaId { get; set; }

        public bool Enabled { get; set; }

        public string Expression { get; set; }

        public string UserFriendlyExpression { get; set; }
    }
}