using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_FactoryMethodPattern
{
    class XueLeiFeng
    {
        public void Test()
        {
            // 简单工厂
            LeiFeng studentA=  SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            LeiFeng studentB = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
            LeiFeng studentC = SimpleFactory.CreateLeiFeng("学雷锋的大学生");

            studentA.BuyRise();
            studentB.Wash();
            studentC.Sweep();

            // 工厂方法
            ILeiFengFactory factory =/* new UndergraduateFactory();*/ new VolunteerFactory();
            LeiFeng student = factory.CreateLeiFeng();
            student.Sweep();
            student.Wash();
            student.BuyRise();




        }
        
    }


    /// <summary>
    /// 雷锋
    /// </summary>
    class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }

        public void Wash()
        {
            Console.WriteLine("洗衣");
        }

        public void BuyRise()
        {
            Console.WriteLine("买米");
        }
    }

    /// <summary>
    /// 学雷锋的大学生
    /// </summary>
    class Undergraduate : LeiFeng
    { }

    /// <summary>
    /// 社区志愿者
    /// </summary>
    class Volunteer : LeiFeng
    { }

    #region 简单工厂
    /// <summary>
    /// 简单工厂
    /// </summary>
    class SimpleFactory
    {
        public static LeiFeng CreateLeiFeng(string type)
        {
            LeiFeng result = null;
            switch (type)
            {
                case "学雷锋的大学生":
                    result = new Undergraduate();
                    break;
                case "社区志愿者":
                    result = new Volunteer();
                    break;
            }

            return result;
        }
    }
    #endregion

    #region 工厂方法
    /// <summary>
    /// 雷锋工厂
    /// </summary>
    interface ILeiFengFactory
    {
        LeiFeng CreateLeiFeng();
    }

    /// <summary>
    /// 学雷锋的大学生工厂
    /// </summary>
    class UndergraduateFactory : ILeiFengFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }

    /// <summary>
    /// 社区志愿者工厂
    /// </summary>
    class VolunteerFactory : ILeiFengFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    } 
    #endregion

}
