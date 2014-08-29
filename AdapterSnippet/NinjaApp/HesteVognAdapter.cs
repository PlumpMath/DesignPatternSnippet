using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaApp
{
    class HesteVognAdapter : INinja
    {

        private HesteVogn _hesteVogn;

        public HesteVognAdapter(HesteVogn nyHesteVogn)
        {
            _hesteVogn = nyHesteVogn;
        }


        public void lob()
        {
            _hesteVogn.hestLober();
        }

        public void gaa()
        {
            _hesteVogn.hestgaer();
        }

        public void stands()
        {
            _hesteVogn.heststopper();
        }
    }
}
