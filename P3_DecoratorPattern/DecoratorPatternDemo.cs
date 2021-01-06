using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_DecoratorPattern
{
    public class DecoratorPatternDemo
    {
        public void test()
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA(); // 装饰类， 
            ConcreteDecoratorA d2 = new ConcreteDecoratorA();
            // 对原来的类进行装饰 , 原来的类并不影响（知道）
            d1.SetComponent(c);
            d2.SetComponent(c);
            d2.Operation();



        }
    }


    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作JU");
        }
    }

    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
               
        }

        public override void Operation()
        {
            component.Operation();
        }

    }

    class ConcreteDecoratorA : Decorator
    {
        private string addedState; // 本类独有的功能
        public override void Operation()
        {
            base.Operation(); // 先运行Component的Operation（）
            addedState = "New State";// 执行本类的功能， 相当于对原Component进行了装饰
            Console.WriteLine("具体装饰对象A的操作");
        }
    }


    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddBehavior(); //执行本类的功能， 相当于对原Component进行了装饰
            Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddBehavior()
        { }
    }
}
