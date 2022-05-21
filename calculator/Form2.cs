using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        double n1;
        double n2;
        double result;

        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            n1 =Convert.ToDouble( ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result = n1 + n2;
            lb_result.Text = Convert.ToString(result);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result = n1 - n2;
            lb_result.Text = Convert.ToString(result);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result = n1 * n2;
            lb_result.Text = Convert.ToString(result);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(ed_n1.Text);
            n2 = Convert.ToDouble(ed_n2.Text);
            result = n1 / n2;
            lb_result.Text = Convert.ToString(result);
        }

        private void lb_result_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
