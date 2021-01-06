using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ProxyPattern
{
    class ProxyPatternDemo
    {
        public void Test()
        {
            Proxy proxy = new Proxy();
            proxy.Request();
        
        }
    }

    public abstract class Subject
    {
        public abstract void Request();
    }

    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求");
        }
    }

    /// <summary>
    /// 创建一个代理类， 代理原来的类，执行原来类的行为
    /// 
    /// </summary>
    public class Proxy : Subject
    {
        RealSubject realSubject;
        public override void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Request();
        }
    }

}
