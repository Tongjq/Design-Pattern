using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_DecoratorPattern
{
    public class DecoratorPerson
    {
        public DecoratorPerson()
        { }

        private string name;
        public DecoratorPerson(string name)
        {
            this.name = name;
        }


        public virtual void Show()
        {
            Console.WriteLine($"装扮的{name}");
        }
    }

    /// <summary>
    /// 装饰类
    /// </summary>
    public class DecoratoryFinery : DecoratorPerson
    {
        protected DecoratorPerson component;

        /// <summary>
        /// 装饰   
        /// 这里写一个装饰的方法，， 传入要装饰计的类
        /// </summary>
        /// <param name="person"></param>
        public void Decorate(DecoratorPerson person)
        {
            this.component = person;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
                base.Show();
            }
        }
    }




    public class DecoratoryTShirts : DecoratoryFinery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤TShirts");
            base.Show();
        }
    }

    class DecoratoryBigTrouser : DecoratoryFinery
    {
        public override void Show()
        {
            Console.WriteLine("跨裤");
            base.Show();
        }
    }

    class DecoratoryTie : DecoratoryFinery
    {
        public override void Show()
        {
            Console.WriteLine("领带");
            base.Show();
        }
    }

    class DecoratoryLeatherShoses : DecoratoryFinery
    {
        public override void Show()
        {
            Console.WriteLine("皮鞋");
            base.Show();
        }
    }
}
