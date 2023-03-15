using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Footwear : Product
    {
        public string Type { get; set; }

        public override void GetDiscount()
        {
            Console.WriteLine($"название: {Name}\n" +
                $"тип: {Type}\n" +
                $"цена: {Price}");
        }
    }
}
