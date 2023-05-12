using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PZ_8
{
    internal class School : ContactObject
    {
        public string Address { get; set; } // адрес
        public string Director { get; set; } // директор

        public School(string name, string phone, string address, string director) : base(name, phone)
        {
            Address = address;
            Director = director;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Образовательное учреждение");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Телефон: " + Phone);
            Console.WriteLine("Адрес: " + Address);
            Console.WriteLine("Директор: " + Director);
        }
    }
}
