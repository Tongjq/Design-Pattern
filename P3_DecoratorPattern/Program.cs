using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  ConcreteComponent c = new ConcreteComponent();
              //ConcreteDecoratorA d1 = new ConcreteDecoratorA();
              ConcreteDecoratorB d2 = new ConcreteDecoratorB();

             // d1.SetComponent(c);
              d2.SetComponent(c);
              d2.Operation();

              Console.ReadKey();*/


            DecoratorPerson person = new DecoratorPerson("xiaocai");
            DecoratoryTShirts tShirts = new DecoratoryTShirts();

            tShirts.Decorate(person);

            tShirts.Show();

            Console.ReadKey();
        }
    }
}
