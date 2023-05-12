using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_3
{
    internal class BinaryTree
    {
        private Node Root; // корень дерева

        public BinaryTree()
        {
            Root = null;
        }

        // метод для добавления узла в дерево
        private void Add(int data, ref Node node)
        {
            if (node == null)
            {
                node = new Node(data);
            }
            else if (data < node.Data)
            {
                Add(data, ref node.Left);
            }
            else
            {
                Add(data, ref node.Right);
            }
        }

        // метод для построения сбалансированного дерева с n узлами
        public void BuildBalancedTree(int n)
        {
            int[] sortedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                sortedArray[i] = i + 1;
            }
            Root = BalancedTreeFromArray(sortedArray, 0, n - 1);
        }

        // вспомогательный метод для построения сбалансированного дерева из отсортированного массива
        private Node BalancedTreeFromArray(int[] arr, int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            int mid = (start + end) / 2;
            Node node = new Node(arr[mid]);
            node.Left = BalancedTreeFromArray(arr, start, mid - 1);
            node.Right = BalancedTreeFromArray(arr, mid + 1, end);
            return node;
        }

        // метод для нахождения среднего значения информационных полей узлов дерева
        public double AverageValue()
        {
            int sum = 0; // сумма информационных полей узлов
            int count = 0; // количество узлов
            Traverse(Root, ref sum, ref count);
            return count > 0 ? (double)sum / count : 0;
        }

        // вспомогательный метод для обхода дерева в глубину (DFS)
        private void Traverse(Node node, ref int sum, ref int count)
        {
            if (node != null)
            {
                sum += node.Data;
                count++;
                Traverse(node.Left, ref sum, ref count);
                Traverse(node.Right, ref sum, ref count);
            }
        }

        // метод для подсчета количества узлов дерева с положительными и отрицательными значениями информационных полей
        public void CountPositiveAndNegative(out int positiveCount, out int negativeCount)
        {
            positiveCount = 0;
            negativeCount = 0;
            TraversePositiveNegative(Root, ref positiveCount, ref negativeCount);
        }

        // вспомогательный метод для обхода дерева в глубину (DFS) с подсчетом положительных и отрицательных значений
        private void TraversePositiveNegative(Node node, ref int positiveCount, ref int negativeCount)
        {
            if (node != null)
            {
                if (node.Data > 0)
                {
                    positiveCount++;
                }
                else if (node.Data < 0)
                {
                    negativeCount++;
                }
                TraversePositiveNegative(node.Left, ref positiveCount, ref negativeCount);
                TraversePositiveNegative(node.Right, ref positiveCount, ref negativeCount);
            }
        }
    }
}
