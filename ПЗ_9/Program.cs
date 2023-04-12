using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполнение значений Client
            Client client = new Client();
            client.ClientDouble(32.4);
            client.ClientInt(1);
            client.ClientChar('*');

            Console.WriteLine("Нажмите Enter, чтобы продолжить");
            Console.ReadLine();

            //Заполнение значений Origin
            Origin origin = new Origin();
            origin.OriginDouble(21.1);
            origin.OriginInt(0);
            origin.OriginChar('*');

            Console.WriteLine("Нажмите Enter, чтобы завершить");
            Console.ReadLine();
            Console.WriteLine("Конец");
            Console.ReadLine();
        }
    }
}
