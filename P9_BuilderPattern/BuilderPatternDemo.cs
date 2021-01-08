using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_BuilderPattern
{
    class BuilderPatternDemo
    {
        public void Test()
        {
            Director director = new Director();
            Builder builderA = new ConcreteBuilder1();
            Builder builderB = new ConcreteBuilder2();

            director.Construct(builderA);
            Product p1= builderA.GetResult();
            p1.Show();

        }
    }

    class Product
    {
        IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\n Product Create ----");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }

    }


    abstract class Builder
    {
        public abstract void BuilderPartA();
        public abstract void BuilderPartB();
        public abstract Product GetResult();
    }

    class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();
        public override void BuilderPartA()
        {
            product.Add("部件A");
        }

        public override void BuilderPartB()
        {
            product.Add("部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();
        public override void BuilderPartA()
        {
            product.Add("部件X");
        }

        public override void BuilderPartB()
        {
            product.Add("部件Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }
    }

}
