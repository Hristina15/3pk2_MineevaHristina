using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Sweater : Product
    {
        public double Size { get; set; }

        public override void GetDiscount()
        {
            Console.WriteLine($"модель: {Name}\n" +
                $"размер: {Size}\n" +
                $"цена: {Price}");

        }
    }
}
