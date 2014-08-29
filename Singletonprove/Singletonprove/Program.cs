using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletonprove
{
    class Program
    {
        static void Main(string[] args)
        {

            Catalog c = Catalog.GetIntance();

            Console.WriteLine(c.skrivdb());
            Console.ReadLine();

            /* Catalog c = new Catalog();
            c.add("mikkel");
            c.add("hej");
            c.add("prut");

            Console.WriteLine(c.Size);


            Catalog c2 = new Catalog();
            c2.add("mette");
            Console.WriteLine(c2.Size);





            Console.ReadLine();
            */
        }

    }


    
}
