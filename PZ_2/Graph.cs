using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_2
{
    internal class Graph
    {
        private int[,] a; // матрица смежности графа

        public Graph(int[,] a)
        {
            this.a = a;
        }

        // метод для проверки связности графа
        public bool IsConnected()
        {
            int n = a.GetLength(0); // количество вершин в графе
            bool[] visited = new bool[n]; // массив для отметки посещенных вершин
            D(0, visited); // запускаем обход графа в глубину из первой вершины

            // если все вершины были посещены, то граф связный
            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    return false;
                }
            }
            return true;
        }

        // рекурсивный метод обхода графа в глубину
        private void D(int currentVertex, bool[] visited)
        {
            visited[currentVertex] = true;
            int n = a.GetLength(0);

            // проходим по всем вершинам, смежным с текущей, и рекурсивно вызываем обход из них
            for (int i = 0; i < n; i++)
            {
                if (a[currentVertex, i] != 0 && !visited[i])
                {
                    D(i, visited);
                }
            }
        }
    }
}
