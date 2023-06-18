using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA classA = new ClassA();
            ClassB classB = new ClassB();
            ClassC classC = new ClassC();
            ClassD classD = new ClassD();

            Facade facade = new Facade(classA, classB, classC, classD);

            WorkFacade workFacade = new WorkFacade(facade);

            workFacade.CreateApplication();

            Console.ReadLine();
        }
    }
}
