using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_9
{
    internal class Origin
    {
        public void OriginDouble(double g) //Параметр типа double
        {
            Console.WriteLine(g); //Вывод на экран
        }

        public void OriginInt(int g) //Параметр принимает целочисленное значение
        {
            Console.WriteLine(g);
        }

        public void OriginChar(char g) //Параметр принимает символьный тип
        {
            Console.WriteLine(g);
        }
    }
}
