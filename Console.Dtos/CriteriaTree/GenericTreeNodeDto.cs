using System.Collections.Generic;

namespace Skynet.Dtos.CriteriaTree
{
    public class GenericTreeNodeDto<TNode>
        where TNode : CriteriaTreeNodeBaseDto
    {
        public GenericTreeNodeDto(TNode node)
        {
            Current = node;
            Childs = new List<GenericTreeNodeDto<TNode>>();
        }

        public TNode Current { get; }
        public List<GenericTreeNodeDto<TNode>> Childs { get; }

        public void AddChildren(IEnumerable<TNode> children)
        {
            foreach (var child in children)
            {
                Childs.Add(new GenericTreeNodeDto<TNode>(child));
            }
        }
    }
}