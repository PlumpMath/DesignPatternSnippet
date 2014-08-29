using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory PF = new ProductFactory();
            IProduct newProduct = null;

            Console.WriteLine("enter a product number: ");
            newProduct = PF.makenewProduct(Console.ReadLine());
            dowork(newProduct);
            Console.ReadLine();

        }


        public static void dowork(IProduct aProduct)
        {
            aProduct.getName();
            aProduct.getAbility();
        }

    }
}
