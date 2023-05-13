using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            // Создаем дерево
            BinaryTree tree = new BinaryTree();

            // Генерируем случайные значения и добавляем их в дерево
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int value = random.Next(10, 1001);
                tree.Insert(value);
            }

            // Выводим элементы дерева в порядке возрастания 
            Console.Write("Элементы дерева: ");
            tree.InOrderTraversal(tree.Root);

            // Подсчитываем сумму элементов дерева
            int sum = tree.Root.Sum();
            Console.WriteLine($"\nСумма элементов дерева: {sum}");

            //Задание 2
            BinaryTree tree1 = new BinaryTree();

            // Добавляем элементы в дерево
            tree1.Insert(35);
            tree1.Insert(81);
            tree1.Insert(67);
            tree1.Insert(90);
            tree1.Insert(11);
            tree1.Insert(87);
            tree1.Insert(23);

            // Выводим элементы дерева в порядке возрастания 
            Console.Write("Элементы дерева: ");
            tree1.InOrderTraversal(tree1.Root);

            // Подсчитываем количество внутренних узлов дерева
            int count = tree1.Root.CountInternalNodes();
            Console.WriteLine($"\nКоличество внутренних узлов: {count}");

            //Задание 3
            BinaryTree tree2 = new BinaryTree();

            tree2.Insert(16);
            tree2.Insert(25);
            tree2.Insert(89);
            tree2.Insert(-40);
            tree2.Insert(33);
            tree2.Insert(-56);
            tree2.Insert(60);

            // Выводим элементы дерева в порядке возрастания 
            Console.Write("Элементы дерева: ");
            tree2.InOrderTraversal(tree2.Root);

            // Копируем отрицательные значения в список
            List<int> negativeValues = new List<int>();
            tree.Root.CopyNegativeValuesTo(negativeValues);

            Console.Write("\nОтрицательные значения: ");
            foreach (int value in negativeValues)
            {
                Console.WriteLine(value + " ");
            }
        }
    }
}

