using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_FacadePattern
{
    class Stock
    {
    }

    /// <summary>
    /// 股票1
    /// </summary>
    public class Stock1
    {
        /// <summary>
        /// 卖股票
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("股票1卖出");
        }

        /// <summary>
        /// 买股票
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("股票1买入");
        }


    }
    /// <summary>
    /// 国债
    /// </summary>
    public class NatoinalDebt1
    {
        /// <summary>
        /// 卖国债
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("国债1卖出");
        }

        /// <summary>
        /// 买国债
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("国债1买入");
        }

    }/// <summary>
     /// 房地产
     /// </summary>
    public class Realty1
    {
        /// <summary>
        /// 卖房地产
        /// </summary>
        public void Sell()
        {
            Console.WriteLine("房地产1卖出");
        }

        /// <summary>
        /// 买房地产
        /// </summary>
        public void Buy()
        {
            Console.WriteLine("房地产1买入");
        }


    }
}
