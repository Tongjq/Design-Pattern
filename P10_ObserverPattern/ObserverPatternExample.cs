using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_ObserverPattern
{
    class ObserverPatternExample
    {
        /// 老板来了前台秘书就通知给一个同事，同事们知道老板来了就开始工作
        public void Test()
        {

            /// 秘书冰冰
            Mishu bingbing = new Mishu();

            /// 看股票的同事
            StockObserver zhangsan = new StockObserver("zhangsan", bingbing);




            /// 看股票的同事
            NBAObserver lisi = new NBAObserver("lisi", bingbing);
            bingbing.Attach(zhangsan);
            bingbing.Attach(lisi);


            bingbing.SubjectState = "老板来了 boss coming";

            bingbing.Notify();
        }
    }


    #region 耦合版
    /* /// <summary>
     /// 秘书类
     /// </summary>
     class Secretary
     {
         // 同事列表
         private IList<StockObserver> observers = new List<StockObserver>();
         private string action;

         /// <summary>
         ///  有几个同事来找前台帮忙， 于是就添加几个同事到集合
         /// </summary>
         /// <param name="stockObserver"></param>
         public void Attach(StockObserver stockObserver)
         {
             observers.Add(stockObserver);
         }

         /// <summary>
         ///  同事， 当老板来时， 就给找过她的同事挨个打电话通知
         /// </summary>
         public void Notify()
         {
             foreach (StockObserver observer in observers)
                 observer.Update();

         }

         /// <summary>
         /// 前台状态  老板回来了就设置
         /// </summary>
         public string SecretaryAction
         {
             get { return action; }
             set { action = value; }
         }
     }

     /// <summary>
     /// 同事类
     /// </summary>
     class StockObserver
     {
         private string name;
         private Secretary sub;
         public StockObserver(string name, Secretary sub)
         {
             this.name = name;
             this.sub = sub;
         }

         public void Update()
         {
             Console.WriteLine($"{sub.SecretaryAction} {name} 关掉股票， 继续工作");
         }

     } */
    #endregion





 
   

    /// <summary>
    /// 通知者接口  前台秘书的接口
    /// </summary>
   public interface Subject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();

        string SubjectState
        {
            get;set;
        }
    }

    /// <summary>
    /// 抽象观察者   同事们的接口
    /// </summary>
    public abstract class Observer
    {
        protected string name;
        protected Subject subject;

        public Observer(string name, Subject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public abstract void Update();

    }


    /// <summary>
    /// 同事类 上班炒股的同事
    /// </summary>
   public class StockObserver:Observer
    {
        public StockObserver(string name, Subject sub) : base(name, sub)
        { }
       

        public override void Update()
        {
            Console.WriteLine($"{subject.SubjectState} {name} 关掉股票， 继续工作");
        }

    }


    /// <summary>
    /// 同事类 上班看NBA的同事
    /// </summary>
    public class NBAObserver : Observer
    {
        public NBAObserver(string name, Subject sub) : base(name, sub)
        { }


        public override void Update()
        {
            Console.WriteLine($"{subject.SubjectState} {name} 关掉直播， 继续工作");
        }

    }


    /// <summary>
    /// 秘书--- 具体的通知类
    /// </summary>
    public class Mishu : Subject
    {
        // 同事列表
        private IList<Observer> observers = new List<Observer>();

        /// <summary>
        /// 秘书的状态
        /// </summary>
        private string action;
        public string SubjectState
        { 
            get => action; 
            set => action= value; 
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in observers)
                observer.Update();
        }
    }
}
