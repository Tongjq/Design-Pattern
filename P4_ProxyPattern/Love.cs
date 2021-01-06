using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ProxyPattern
{
    public class Love
    {
        public void Test()
        {
            SchoolGirl mm = new SchoolGirl
            {
                Name = "Marry"
            };
              ProxyZhuiGirl proxy = new ProxyZhuiGirl(mm);
            proxy.GiveDolls();
            proxy.GiveChocolate();
            proxy.GiveFlowers();


        }
    }

    public interface GiveGift
    {
        void GiveDolls();
        void GiveFlowers();
        void GiveChocolate();
    }

    /// <summary>
    /// 追求者
    /// </summary>
    public class Pursuit : GiveGift
    {
        private SchoolGirl girl;

        public Pursuit(SchoolGirl mm)
        {
            girl = mm;
        }

        public void GiveChocolate()
        {
            Console.WriteLine($"{girl.Name} 送你洋娃娃");
        }

        public void GiveDolls()
        {
            Console.WriteLine($"{girl.Name} 送你鲜花");
        }

        public void GiveFlowers()
        {
            Console.WriteLine($"{girl.Name} 送你巧克力");
        }
    }

    /// <summary>
    /// 被追求的女孩
    /// </summary>
    public class SchoolGirl
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    /// <summary>
    /// 创建一个代理类代理追求者给女孩送东西
    /// </summary>

    public class ProxyZhuiGirl : GiveGift
    {
        Pursuit boy;
        public ProxyZhuiGirl(SchoolGirl mm)
        {
            boy = new Pursuit(mm);
        }
        public void GiveChocolate()
        {
            boy.GiveChocolate();
        }

        public void GiveDolls()
        {
            boy.GiveDolls();
        }

        public void GiveFlowers()
        {
            boy.GiveFlowers();
        }
    }
}
