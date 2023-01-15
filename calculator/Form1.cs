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
        string X = "", Y;
        private void Btn0_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "0";
            }
            else
            {
                X = X + "0";
            }
            TBox1.Text = X;
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "1";
            }
            else
            {
                X = X + "1";
            }
            TBox1.Text = X;
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "2";
            }
            else
            {
                X = X + "2";
            }
            TBox1.Text = X;
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "3";
            }
            else
            {
                X = X + "3";
            }
            TBox1.Text = X;
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "4";
            }
            else
            {
                X = X + "4";
            }
            TBox1.Text = X;
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "5";
            }
            else
            {
                X = X + "5";
            }
            TBox1.Text = X;
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "6";
            }
            else
            {
                X = X + "6";
            }
            TBox1.Text = X;
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "7";
            }
            else
            {
                X = X + "7";
            }
            TBox1.Text = X;
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "8";
            }
            else
            {
                X = X + "8";
            }
            TBox1.Text = X;
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            if (X == "0")
            {
                X = "9";
            }
            else
            {
                X = X + "9";
            }
            TBox1.Text = X;
        }
        private void BtnDecimalPoint_Click(object sender, EventArgs e)
        {
            int index = X.IndexOf(".");
            if (index == -1)
            {
                X = X + ".";
            }
            TBox1.Text = X;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool End = X.EndsWith("0");
            int index = X.IndexOf(".");
            if (X == "")
            {
                X = "0";
            }
            else if (End == true  && index != -1)
            {
                X = "0";
            }
            myCal = myCalAdd;
            Y = X;
            X = "";
        }
        private void BtnSub_Click(object sender, EventArgs e)
        {
            bool End = X.EndsWith("0");
            int index = X.IndexOf(".");
            if (X == "")
            {
                X = "0";
            }
            else if (End == true && index != -1)
            {
                X = "0";
            }
            myCal = myCalSub;
            Y = X;
            X = "";
        }
        private void BtnMul_Click(object sender, EventArgs e)
        {
            bool End = X.EndsWith("0");
            int index = X.IndexOf(".");
            if (X == "")
            {
                X = "0";
            }
            else if (End == true && index != -1)
            {
                X = "0";
            }
            myCal = myCalMul;
            Y = X;
            X = "";
        }
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            bool End = X.EndsWith("0");
            int index = X.IndexOf(".");
            if (X == "")
            {
                X = "0";
            }
            else if (End == true && index != -1)
            {
                X = "0";
            }
            myCal = myCalDiv;
            Y = X;
            X = "";
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            TBox1.Text = "0";
            X = "";
        }
        private void BtnNeg_Click(object sender, EventArgs e)
        {
            int index = X.IndexOf("-");
            if (index == -1)
            {
                X = "-" + X;
            }
            else
            {
                X = X.Substring(1);
            }
            TBox1.Text = X;
        }
        private void BtnResult_Click(object sender, EventArgs e)
        {
            bool End = X.EndsWith("0");
            int index = X.IndexOf(".");
            if (X == "")
            {
                X = "0";
            }
            else if (End == true && index != -1)
            {
                X = "0";
            }
            if (myCal == myCalDiv)
            {
                if (X == "0" || Y == "0")
                {
                    X = "0";
                }
            }
            try
            {
                myCal.X = double.Parse(X);
                myCal.Y = double.Parse(Y);
                X = myCal.Answer().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TBox1.Text = X;
            Y = X;
            X = "";
        }
    }
}