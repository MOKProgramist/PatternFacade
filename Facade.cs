using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFacade
{
    // точка входа в приложение
    internal class Facade
    {
        ClassA classA;
        ClassB classB;
        ClassC classC;
        ClassD classD;
        public Facade(ClassA ClassA, ClassB ClassB, ClassC ClassC, ClassD ClassD)
        {
            this.classA = ClassA;
            this.classB = ClassB;
            this.classC = ClassC;
            this.classD = ClassD;
        }


        public void Start()
        {
            this.classA.MethodA3();
            this.classB.MethodB2();
            this.classC.MehodC1();
        }

        public void Stop()
        {
            Console.WriteLine("Завершена работа адаптера. Спасибо.");
        }
    }
}
