using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_4
{
    internal class BinaryTree
    {
        public Node Root { get; private set; }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Root.Insert(value);
            }
        }

        public void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }
    }
}
