﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySnippet
{
    public class Product1 : IProduct
    {
        public void getName()
        {
            Console.WriteLine("product 1");
        }

        public void getAbility()
        {
            Console.WriteLine("ability 1");
        }
    }
}
