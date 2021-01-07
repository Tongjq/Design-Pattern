using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_TemplateMethodPattern
{
    public class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("question1");
            Console.WriteLine("answer is "+ Answer1());
        }

        public void TestQuestion2()
        {
            Console.WriteLine("question2");
            Console.WriteLine("answer is " + Answer2());
        }

        public void TestQuestion3()
        {
            Console.WriteLine("question3");
            Console.WriteLine("answer is " + Answer3());
        }

        public virtual string Answer1()
        {
            return "";
        }

        public virtual string Answer2()
        {
            return "";
        }

        public virtual string Answer3()
        {
            return "";
        }


    }

    public class TestPaperA:TestPaper
    {

        public override string Answer1()
        {
            return "A";
        }

        public override string Answer2()
        {
            return "B";
        }

        public override string Answer3()
        {
            return "C";
        }
    }




    public class TestPaperB : TestPaper
    {
        public override string Answer1()
        {
            return "A";
        }

        public override string Answer2()
        {
            return "A";
        }

        public override string Answer3()
        {
            return "D";
        }
    }
}
