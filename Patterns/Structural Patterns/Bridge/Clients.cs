using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Bridge
{
    internal class Clients
    {
        public void CLienCode(Abstraction abstraction)
        {
            Console.WriteLine(abstraction.Operation());
        }
    }
}
