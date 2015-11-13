using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Action add1 = new Action();
            add1.a = 20;
            add1.b = 32;
         
            Console.WriteLine(Convert.ToString(  add1.Add()  )  );
            Console.ReadKey();
        }
    }
}
