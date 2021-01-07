using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_TemplateMethodPattern
{
    class TemplateMethodPatternDemo
    {
    }

   public  abstract class AbstractClass
    {
        public abstract void PermitiveOperation1();
        public abstract void PermitiveOperation2();

        public void TemplateMethod()
        {
            PermitiveOperation1();
            PermitiveOperation2();
            Console.WriteLine("");
        }
    }


    public class ConcreteClassA : AbstractClass
    {
        public override void PermitiveOperation1()
        {
            Console.WriteLine("A class 1 method imp");
        }

        public override void PermitiveOperation2()
        {
            Console.WriteLine("A class 2 method imp");
        }
    }


    public class ConcreteClassB : AbstractClass
    {
        public override void PermitiveOperation1()
        {
            Console.WriteLine("B class 1 method imp");
        }

        public override void PermitiveOperation2()
        {
            Console.WriteLine("B class 2 method imp");
        }
    }
}
