using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3
{
    internal class Node
    {
        public int Data; 
        public Node Left; 
        public Node Right; 

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
