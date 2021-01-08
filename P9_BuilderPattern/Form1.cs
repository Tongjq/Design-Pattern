using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_BuilderPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Yellow);
            Graphics gThin = pictureBox1.CreateGraphics();
            PersonBuilder ptb = new PersonThinBuilder(gThin, p);
            PersonDirector director = new PersonDirector(ptb);
            director.CreatePerson();

           
        }
    }
}
