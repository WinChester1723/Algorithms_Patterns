﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Patterns.Patterns.Structural_Patterns.Proxy
{
    internal class ClientProxy
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
