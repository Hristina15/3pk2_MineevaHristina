using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.BuildBalancedTree(5);
            Console.WriteLine("Среднее арифметическое: " + tree.AverageValue());
            int positiveCount, negativeCount;
            tree.CountPositiveAndNegative(out positiveCount, out negativeCount);
            Console.WriteLine("Положительных узлов: " + positiveCount);
            Console.WriteLine("Отрицательных узлов: " + negativeCount);
            Console.ReadLine();
        }
    }
}
