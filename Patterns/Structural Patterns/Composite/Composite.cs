using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Composite
{
    internal class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }

        public override string Operation()
        {
            int i = 0;
            string result = "BRanch(";

            foreach (Component child in this._children)
            {
                result += child.Operation();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }
            return result + ")";
        }
    }
}
