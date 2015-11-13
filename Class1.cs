using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
 class Action: Addition
    {
        //автосвойства
        public double a { get; set; }
        public double b { get; set; }


        //реалиованные методы 
        public override double Add()
        {
            return a + b;
        }


        //throw new NotImplementedException();  Автоматически вылезло . я так понимаю это обработка исключения
        public override double Sub()
        {
            return a - b;

            throw new NotImplementedException();
        }

        //Деление
        public override double Divide()
        {

            return a / b;
            throw new NotImplementedException();
        }

       // Умножение

        public override double Multiply()
        {
            return a * b;
            throw new NotImplementedException();
        }
    }
}
 