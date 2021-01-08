using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_BuilderPattern
{
    public abstract class PersonBuilder
    {
        protected Graphics g;
        protected Pen p;

        public PersonBuilder(Graphics g, Pen p)
        {
            this.g = g;
            this.p = p;
        }

        public abstract void BuildeHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();

    }


    class PersonThinBuilder : PersonBuilder
    {
        public PersonThinBuilder(Graphics g, Pen p) : base(g, p)
        {

        }
        public override void BuildArmLeft()
        {
            g.DrawEllipse(p, 50, 20, 30, 30);
        }

        public override void BuildArmRight()
        {
            g.DrawRectangle(p, 60, 50, 10, 50);
        }

        public override void BuildBody()
        {
            g.DrawLine(p, 60, 50, 40, 100);
        }

        public override void BuildeHead()
        {
            g.DrawLine(p, 70, 50, 90, 100);
        }

        public override void BuildLegLeft()
        {
            g.DrawLine(p, 60, 100, 45, 150);
        }

        public override void BuildLegRight()
        {
            g.DrawLine(p, 70, 100, 80, 150);
        }
    }
}
