using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Adapter
{
    internal class Adaptee
    {
        public string GetSpecificRequest() => "SpecificRequest";//instead of return/ and using lambda
    }
}
