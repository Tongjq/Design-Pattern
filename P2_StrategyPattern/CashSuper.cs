using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 收费抽象父类
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 收费的抽象方法
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public abstract double acceptCash(double money);
    }
}
