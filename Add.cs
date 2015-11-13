using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
 abstract class Addition:IAction
    {
        public abstract double Add();
        public abstract double Sub();
        public abstract double Divide();
        public abstract double Multiply();

    }
}


