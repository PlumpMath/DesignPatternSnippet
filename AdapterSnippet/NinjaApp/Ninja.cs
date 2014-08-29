using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp
{
    class Ninja : INinja
    {
        public void lob()
        {
            Console.WriteLine("ninja løber");
        }

        public void gaa()
        {
            Console.WriteLine("ninja går");
        }

        public void stands()
        {
            Console.WriteLine("ninja er standset");
        }
    }
}
