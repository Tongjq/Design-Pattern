using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_DecoratorPattern
{
   public class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public void WearTShirts()
        {
            Console.WriteLine("大T恤");
        }

        public void WearBigTrouser()
        {
            Console.WriteLine("跨裤");
        }

        public void WearTie()
        {
            Console.WriteLine("领带");
        }

        public void WearLeatherShoses()
        {
            Console.WriteLine("皮鞋");
        }

        public void Show()
        {
            Console.WriteLine($"装扮的{name}");
        }
    }
}
