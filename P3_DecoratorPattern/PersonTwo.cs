using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_DecoratorPattern
{
    public class PersonTwo
    {
    }

    abstract class Finery
    {
        public abstract void Show();
    }

    class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("跨裤");
        }
    }

    class Tie : Finery
    {
        public override void Show()
        {
            Console.WriteLine("领带");
        }
    }

    class LeatherShoses : Finery
    {
        public override void Show()
        {
            Console.WriteLine("皮鞋");
        }
    }

  
}
