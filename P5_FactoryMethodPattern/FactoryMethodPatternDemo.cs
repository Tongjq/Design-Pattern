using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_FactoryMethodPattern
{
    class FactoryMethodPatternDemo
    {
        public void Test()
        {
            IFactory operFactory = new AddFactory();
            Operation oper = operFactory.CreateOperation();

            oper.NumberA = 1;
            oper.NumberB = 2;

            double reautlt= oper.GetResult();
        }
    }


    interface IFactory
    {
        Operation CreateOperation();
    }

    class AddFactory : IFactory
    {
        public  Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }

    class SubFactrory : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }


    public class Operation
    {
        private double _numberA;
        private double _numberB;

        public double NumberA
        {
            set { _numberA = value; }

            get { return _numberA; }
        }

        public double NumberB
        {
            set { _numberB = value; }

            get { return _numberB; }

        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

    }

    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;

            return result;
        }
    }

    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;

            return result;
        }
    }

}
