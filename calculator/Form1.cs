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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbox1.Text = "0";
        }
        private void btn0_Click(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Button btnHit;
            btnHit = (Button)sender;
            tbox1.Text = btnHit.Text;
        }
        private void btn2_Click(object sender, EventArgs e)
        {

        }
        private void btn3_Click(object sender, EventArgs e)
        {

        }
        private void btn4_Click(object sender, EventArgs e)
        {

        }
        private void btn5_Click(object sender, EventArgs e)
        {

        }
        private void btn6_Click(object sender, EventArgs e)
        {

        }
        private void btn7_Click(object sender, EventArgs e)
        {

        }
        private void btn8_Click(object sender, EventArgs e)
        {

        }
        private void btn9_Click(object sender, EventArgs e)
        {

        }
        private void btn10_Click(object sender, EventArgs e)
        {

        }
        private void btn11_Click(object sender, EventArgs e)
        {

        }
        private void btn12_Click(object sender, EventArgs e)
        {

        }
        private void btn13_Click(object sender, EventArgs e)
        {

        }
        private void btn14_Click(object sender, EventArgs e)
        {

        }
        private void btn15_Click(object sender, EventArgs e)
        {

        }
        private void btn16_Click(object sender, EventArgs e)
        {

        }
        private void btn17_Click(object sender, EventArgs e)
        {

        }
        private void tbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
