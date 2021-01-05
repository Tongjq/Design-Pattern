using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ///简单工厂模式
            Operation operation;
            operation = OperationFactory.CreateOperate("+");
            operation.NumberA = 2;
            operation.NumberB = 3;
            double result = operation.GetResult();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
