using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal static class Store
    {
        public static double SaveOrder(Product product, Client client)
        {
            return product.Price - product.Price * Sale(client);
        }

        public static double Sale(Client client)
        {
            if (client.AllPurshares > 1000)
            {
                return 0.4;
            }
            else if (client.AllPurshares > 2000)
            {
                return 0.5;
            }
            else return 0;
        }
    }
}
