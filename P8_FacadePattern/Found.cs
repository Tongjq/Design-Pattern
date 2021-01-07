using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_FacadePattern
{
    public class Found
    {
        Stock1 gun1;
        NatoinalDebt1 na1;
        Realty1 re1;
        public Found()
        {
            gun1 = new Stock1();
            na1 = new NatoinalDebt1();
            re1 =new Realty1();
        }


        public void BuyFound()
        {
            gun1.Buy();
            na1.Buy();
            re1.Buy();
        }

        public void SellFound()
        {
            gun1.Sell();
            na1.Sell();
            re1.Sell();
        }

    }
}
