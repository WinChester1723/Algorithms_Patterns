using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Decorator
{
    internal class ConcreteComponentDecorator : ComponentDecorator
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
