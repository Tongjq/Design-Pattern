using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 打折收费子类
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        /// <summary>
        /// 初始化时传入折扣
        /// </summary>
        /// <param name="moneyRebate">折扣</param>
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate =double.Parse(moneyRebate);
        }
        /// <summary>
        /// 按折扣收费
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
