using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Generative_Patterns.Factory
{
    internal class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod() => new ConcreteProduct1();
    }
}
