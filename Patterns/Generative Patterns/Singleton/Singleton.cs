using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Generative_Patterns.Singleton
{
    internal sealed class Singleton
    {
        public Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
