using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_4
{
    internal class Node
    {
        public int Value { get; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
        }

        public void Insert(int value)
        {
            if (value < Value)
            {
                if (Left == null)
                {
                    Left = new Node(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else if (value > Value)
            {
                if (Right == null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }

        public int Sum()
        {
            int sum = Value;

            if (Left != null)
            {
                sum += Left.Sum();
            }

            if (Right != null)
            {
                sum += Right.Sum();
            }

            return sum;
        }

        public int CountInternalNodes()
        {
            int count = 0;

            if (Left != null || Right != null)
            {
                count++; // текущий узел - внутренний
            }

            if (Left != null)
            {
                count += Left.CountInternalNodes();
            }

            if (Right != null)
            {
                count += Right.CountInternalNodes();
            }

            return count;
        }

        public void CopyNegativeValuesTo(List<int> list)
        {
            if (Value < 0)
            {
                list.Add(Value);
            }

            if (Left != null)
            {
                Left.CopyNegativeValuesTo(list);
            }

            if (Right != null)
            {
                Right.CopyNegativeValuesTo(list);
            }
        }
    }
}

