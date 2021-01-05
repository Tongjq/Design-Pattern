using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class StrategyPatternDemo
    {
        public static void Test()
        {
            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }
    }

    /// <summary>
    /// Strategy 定义所有支持的算法的公共接口
    /// </summary>
    public abstract class Strategy
    {
        /// <summary>
        ///算法方法
        /// </summary>
        public abstract void AlgorithmInterface();
    }

    /// <summary>
    /// 具体算法A
    /// </summary>
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }

    /// <summary>
    /// 具体算法B
    /// </summary>
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }

    /// <summary>
    /// 具体算法C
    /// </summary>
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法C实现");
        }
    }

    /// <summary>
    /// 上下文 Context， 用一个ConcreteStrategy来配置，维护对一个Strategy的引用
    /// </summary>
    public class Context
    {
        Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }


        // 上下文接口
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
