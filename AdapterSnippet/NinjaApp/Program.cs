using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Ninja nin = new Ninja();

            HesteVogn hesteVogn = new HesteVogn();

            HesteVognAdapter hesteVognAdapter = new HesteVognAdapter(hesteVogn);


            nin.lob();
            hesteVognAdapter.lob();

            nin.stands();
            hesteVognAdapter.stands();

        }
    }
}
