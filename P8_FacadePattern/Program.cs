using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Found jijin = new Found();
            jijin.BuyFound();

            jijin.SellFound();

            Console.ReadKey();

        }
    }
}
