using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Decorator
{
    internal class Decorator : ComponentDecorator
    {
        protected ComponentDecorator _componentDecorator;

        public Decorator(ComponentDecorator component)
        {
            this._componentDecorator = component;        
        }

        public void SetComponent(ComponentDecorator component)
        {
            this._componentDecorator = component;
        }

        public override string Operation()
        {
            if(this._componentDecorator != null)
            {
                return this._componentDecorator.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
