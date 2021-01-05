using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        double total =0d;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[] {"正常收费","打八折","打七折","打五折" });
            cbxType.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double totalPrices = 0d;
            /* switch (cbxType.SelectedIndex)
             {
                 case 0:
                     totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNumber.Text);
                     break;
                 case 1:
                     totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNumber.Text)* 0.8;
                     break;
                 case 2:
                     totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNumber.Text)* 0.7;
                     break;
                 case 3:
                     totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNumber.Text)* 0.5;
                     break;

             }*/

            /*  CashSuper csuper = CashFactory.CreateCashAccept(cbxType.SelectedItem.ToString());
              totalPrices = csuper.acceptCash(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNumber.Text));*/

            /// 使用策略模式
            CashContext cc = new CashContext((cbxType.SelectedItem.ToString()));
           
            totalPrices= cc.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNumber.Text));
            total = total + totalPrices;
            lbxList.Items.Add("单价： " + txtPrice.Text + " 数量: " + txtNumber.Text + " " + cbxType.SelectedItem + " 合计： " + totalPrices.ToString());
            lblResut.Text = total.ToString();
        }
    }
}
