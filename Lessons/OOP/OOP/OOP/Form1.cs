using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        float Cal(int qty, float price)
        {
            return qty*price;
        }

        private void calBtn_Click(object sender, EventArgs e)
        {

            int qty = Convert.ToInt32(qtyTxt.Text);
            float price = Convert.ToSingle(uPriceTxt.Text);
            totalTxt.Text = (Cal(qty, price).ToString());

        }
    }
}
