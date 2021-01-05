using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CashReturn : CashSuper
    {
        private double moneyCondition = 1d;
        private double moneyReturn = 0.0d;

        /// <summary>
        /// 构造是传入返利条件和反利值
        /// </summary>
        /// <param name="moneyCondition">返利条件（满300减100，300）</param>
        /// <param name="moneyReturn">返利值（满300减100，100）</param>
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);

        }
        public override double acceptCash(double money)
        {
            double result = money;
            if (money > moneyCondition)
                // 满300减100， 满700减200
                // 购买了700的东西， 就减200
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;

            return result;

        }
    }
}
