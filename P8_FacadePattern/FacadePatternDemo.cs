using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_FacadePattern
{
    class FacadePatternDemo
    {
        public void Test()
        {
            Facede facede = new Facede();
            facede.MethodA();
            facede.MethodB();
            Console.ReadKey();
        }
    }


    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法1");
        }
    }

    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法2");
        }
    }

    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("子系统方法3");
        }
    }

    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("子系统方法4");
        }
    }


    class Facede
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facede()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n Method group A() -------------");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\n Method group B() -------------");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}

