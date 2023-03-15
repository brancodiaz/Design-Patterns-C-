﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class OrangeCreator : Creator
    {
        public override IFruit FactoryMethod()
        {
            return new Orange();
        }
    }
}
