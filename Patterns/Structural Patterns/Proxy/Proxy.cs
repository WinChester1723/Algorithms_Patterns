using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Proxy
{
    internal class Proxy : ISubject
    {
        private RealSubject _realSUbject;

        public Proxy(RealSubject realSUbject)
        {
            this._realSUbject = realSUbject;
        }

        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSUbject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
