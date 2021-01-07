using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  TestPaper studenA = new TestPaperA();
              studenA.TestQuestion1();
              studenA.TestQuestion2();
              studenA.TestQuestion3();



              TestPaper studenB = new TestPaperB();
              studenB.TestQuestion1();
              studenB.TestQuestion2();
              studenB.TestQuestion3();


              Console.ReadKey();*/



            AbstractClass a;
            a = new ConcreteClassA();
            a.TemplateMethod();

            a = new ConcreteClassB();
            a.TemplateMethod();
            
            Console.ReadKey();

        }
    }
}
