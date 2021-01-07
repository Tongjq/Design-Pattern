using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {/*
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1=(ConcretePrototype1)  p1.Clone();

            Console.WriteLine("Cloned:{0}", c1.Id);

            Console.ReadKey();*/


            #region 原型模式(拷贝， 默认是的浅拷贝)
/*
            Resume resume = new Resume("大鸟");
            resume.SetPersonalInfo("男", "20");

            Resume b = (Resume)resume.Clone();

            resume.Display();

            b.Display();

            Console.ReadKey();*/
            #endregion

            #region 浅拷贝
        /*    ShallowCopyResume shallowCopy = new ShallowCopyResume("浅拷贝");
            shallowCopy.SetWorkExperience("北京", "xx科技");

            ShallowCopyResume c = (ShallowCopyResume)shallowCopy.Clone();
            shallowCopy.SetWorkExperience("上海", "yy科技");


            shallowCopy.Display();

            c.Display();*/
            #endregion

            DeepCopyDemoResume deepCopy = new DeepCopyDemoResume("深拷贝");
            deepCopy.SetWorkExperience("北京", "xx科技");

            DeepCopyDemoResume d = (DeepCopyDemoResume)deepCopy.Clone();
            d.SetWorkExperience("上海", "yy科技");


            deepCopy.Display();

            d.Display();

            Console.ReadKey();

        }
    }
}
