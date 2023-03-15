using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Jeans : Product
    {
        public string colour { get; set; }
        public override void GetDiscount()
        {
            Console.WriteLine($"тип: {Name}\n" +
                $"цвет: {colour}\n" +
                $"цена: {Price}");
        }
    }
}
