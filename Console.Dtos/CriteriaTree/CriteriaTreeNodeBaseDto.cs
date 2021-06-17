using System;

namespace Skynet.Dtos.CriteriaTree
{
    public abstract class CriteriaTreeNodeBaseDto
    {
        public Guid CriteriaId { get; set; }

        public Guid? ParentCriteriaId { get; set; }

        public Guid? BaseCriteriaId { get; set; }

        public string Name { get; set; }
        
        public bool Enabled { get; set; }

        public string Expression { get; set; }

        public string UserFriendlyExpression { get; set; }
    }
}