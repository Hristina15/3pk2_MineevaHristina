using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Client
    {
        public string Name { get; set; }    
        public double AllPurshares { get; set; }

        internal double Buy (double summ)
        {
            AllPurshares += summ;
            return AllPurshares;
        }
    }
}
