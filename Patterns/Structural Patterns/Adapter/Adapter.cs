using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Adapter
{
    internal class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        
        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
