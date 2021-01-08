using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_ObserverPattern
{
    class ObserverPatternDemo
    {
        public static void Test()
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver("X", subject));
            subject.Attach(new ConcreteObserver("Y", subject));
            subject.Attach(new ConcreteObserver("Z", subject));


            subject.SubjectState = "ABC";
            subject.Notify();

        }
    }

    /// <summary>
    /// 抽象通知类
    /// </summary>
    public abstract class SubjectD
    {
        // 通知列表
        private IList<ObserverD> observers = new List<ObserverD>();


        /// <summary>
        /// 添加通知人
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(ObserverD observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 移除通知人
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(ObserverD observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 发送通知
        /// </summary>
        public void Notify()
        {
            foreach (ObserverD observer in observers)
                observer.Update();
        }


    }


    /// <summary>
    /// 抽象通知， 得到主题通知事执行更新
    /// </summary>
    public abstract class ObserverD
    {
        public abstract void Update();

    }

    /// <summary>
    /// 具体主题或者通知者
    /// </summary>
    public class ConcreteSubject : SubjectD
    {
        private string subjectSate;

        /// <summary>
        /// 具体被观察者状态， 当但与通知的触发点
        /// </summary>
        public string SubjectState
        {
            get => subjectSate;
            set => subjectSate = value;
        }
    }


    public class ConcreteObserver : ObserverD
    {
        private string name;
        private string observerState;
        private ConcreteSubject concreteSubject;
        public ConcreteObserver(string name, ConcreteSubject concreteSubject)
        {
            this.concreteSubject = concreteSubject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = concreteSubject.SubjectState;
            Console.WriteLine($"观察者{name}的新状态是{observerState}");
        }
    }
}
