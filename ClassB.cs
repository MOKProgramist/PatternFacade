using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade
{
    internal class ClassB
    {
        public void MethodB1()
        {
            Console.WriteLine("Вызов метода MethodB1 из класса ClassB");
        }
        public void MethodB2()
        {
            Console.WriteLine("Вызов метода MethodA2 из класса ClassB");
        }

        public void MethodB3()
        {
            Console.WriteLine("Вызов метода MethodB3 из класса ClassB");

        }
        public void MethodВ4()
        {

            Console.WriteLine("Вызов метода MethodВ4 из класса ClassB");

        }

    }
}
