using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySnippet
{
    public class ProductFactory
    {

        public IProduct makenewProduct(string newProductType)
        {
            

            if (newProductType == "1")
            {
                return new Product1();
            }
            else if (newProductType == "2")
            {
                return new Product2();
            }
            else
            {
                throw new ArgumentException(string.Format("wrong type: {0}", newProductType));
            }

        }
    }

}
