class Program
{
    public class Graph
    {

        public int Size { get; set; }
        public bool[,] Adjacency { get; set; }
        public bool[] Vector { get; set; }



        public Graph(int size, bool[,] s)
        {
            Adjacency = new bool[size, size]; // инициализация матрицы смежности
            Adjacency = s;
            Vector = new bool[size];
            for (int i = 0; i < size; i++)
                Vector[i] = false; // инициализация вектора 
            Size = size;
        }
        public void Depth(int i)
        {
            Vector[i] = true;

            Console.Write(" {0}" + ' ', i);
            for (int k = 0; k < Size; k++)

                if (Adjacency[i, k] && !(Vector[k]))
                    Depth(k);


        }
        static void Main(string[] args)
        {
            bool[,] a = new bool[5, 5]
            {
                    {false, true, true, false, false}, // матрица смежности 
                    {false, false, false, true, false},
                    {false, true, false, false, true},
                    {false, false, true, false, false},
                    {false, false, false, true, false}
            };



            Graph graph = new Graph(5, a);
            graph.Depth(0);

            bool allvershin = true; // Создаем булевую переменную 
            for (int i = 0; i < graph.Size; i++)
            {
                if (!graph.Vector[i])

                {
                    allvershin = false;
                    break;
                }

            }

            if (allvershin)
                Console.WriteLine(" Значит граф связный");
            else
                Console.WriteLine(" Значит граф не связный");
            Console.ReadLine();



        }

    }
}
