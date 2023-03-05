using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yield_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double investment = Double.Parse(textBox1.Text);
            double yield = Double.Parse(textBox2.Text);

            double return_year_one = investment * yield;

            textBox3.Text = return_year_one.ToString();
        }
    }
}
