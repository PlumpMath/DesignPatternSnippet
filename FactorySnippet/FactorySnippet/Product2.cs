using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySnippet
{
    class Product2 : IProduct
    {
        public void getName()
        {
            Console.WriteLine("product 2");
        }

        public void getAbility()
        {
            Console.WriteLine("ability 2");
        }
    }
}
