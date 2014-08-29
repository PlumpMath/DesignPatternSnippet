using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSnippet
{
    class Adapter : Itarget
    {
        private Adaptee _adaptee = new Adaptee();
        public void request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
