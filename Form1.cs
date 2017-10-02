using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acountingagain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal principal;
            int year;
            double rate;
            string output;
            decimal amount;

            year = Convert.ToInt32(numBox.Text);
            rate = Convert.ToDouble(rateBox.Text);
            principal = Convert.ToDecimal(principalBox.Text);

            output = "Year\t Amount\r\n";
            for (int yearCount = 0; yearCount <= year; yearCount++)
            {
                amount = principal * ((decimal)Math.Pow((1 + rate / 100), yearCount));
                output += (yearCount + "\t" + string.Format("{0:C", amount) + "\r\n" );
            }
        }



    }
}
