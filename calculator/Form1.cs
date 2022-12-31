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

        Cal myCal;
        CalAdd myCalAdd = new CalAdd();
        CalSub myCalSub = new CalSub();
        CalMul myCalMul = new CalMul();
        CalDiv myCalDiv = new CalDiv();
        string X,Y;

        private void Form1_Load(object sender, EventArgs e)
        {
            tbox1.ReadOnly = true;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            X = X + "0";
            tbox1.Text = X;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            X = X + "1";
            tbox1.Text = X;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            X = X + "2";
            tbox1.Text = X;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            X = X + "3";
            tbox1.Text = X;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            X = X + "4";
            tbox1.Text = X;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            X = X + "5";
            tbox1.Text = X;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            X = X + "6";
            tbox1.Text = X;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            X = X + "7";
            tbox1.Text = X;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            X = X + "8";
            tbox1.Text = X;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            X = X + "9";
            tbox1.Text = X;
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            X = X + ".";
            tbox1.Text = X;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            myCal = myCalAdd;
            Y = X;
            X = "";
        }
        private void btnsub_Click(object sender, EventArgs e)
        {
            myCal = myCalSub;
        }
        private void btnmul_Click(object sender, EventArgs e)
        {
            myCal = myCalMul;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            myCal = myCalDiv;
        }
        private void btn15_Click(object sender, EventArgs e)
        {
            tbox1.Text = "0";
        }
        private void btn16_Click(object sender, EventArgs e)
        {

            X = "-" + X;
            tbox1.Text = X;
        }
        private void btn17_Click(object sender, EventArgs e)
        {
            try
            {
                myCal.X = double.Parse(X);
                myCal.Y = double.Parse(Y);
                X = myCal.Answer().ToString();
                tbox1.Text = X;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
