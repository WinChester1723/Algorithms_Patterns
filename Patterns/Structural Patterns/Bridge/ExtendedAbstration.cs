using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Bridge
{
    internal class ExtendedAbstration : Abstraction
    {
        public ExtendedAbstration(IImplementation implementation) : base(implementation) { }

        public override string ToString()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }
}
