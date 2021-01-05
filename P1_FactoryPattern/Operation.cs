namespace P1_FactoryPattern
{
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
}
