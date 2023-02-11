using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Composite
{
    internal class ClientComposite
    {
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESUL: {leaf.Operation()}\n");
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }
            Console.WriteLine($"RESUL: {component1.Operation()}");
        }
    }
}
