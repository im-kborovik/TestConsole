using System;
using System.Collections.Generic;
using System.Text;
using Skynet.Dtos.Adjustments;

namespace Skynet.Dtos.Base
{
    public class Node<T> where T:class
    {
        public List<Node<T>> Children = new List<Node<T>>();
        public Node<T> Parent { get; set; }
        public T AssociatedObject { get; set; }
    }
}
