using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_9
{
    internal class Client
    {
        //Адаптация класса Origin к функциональности класса Client
        public Origin original;
        public Client()
        {
            this.original = new Origin();
        }

        public void ClientDouble(double g) //Метод OriginDouble переименовывается в ClientDouble
        {
            this.original.OriginDouble(g); //Работа без изменений
        }

        public void ClientInt(int g) //Метод OriginInt переименовывается в ClientInt
        {
            this.original.OriginInt(g); //Метод имеет двойное значение параметра
            this.original.OriginInt(g);
        }

        public void ClientChar(char g) //Метод OriginChar переименовывается в ClientChar
        {
            this.original.OriginChar(g);

            for (int i = 0; i < 4; i++) //Вывод параметра 5 раз
            {
                Console.WriteLine(g);
            }
        }
    }
}
