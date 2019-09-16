/*
 * 用C#写了一个简易的计算器，本来是想要实现 运算符→计算值的算法的，但。。。要考虑的点太多（想参考编译原理的算法来完成），我也没多少时间来完成这个任务，故只写了一个简易的计算器。
 * 作者：吕翔宇
 * E-Mail : lvxiangyu11@gmail.com
 * 创作时间：2019年9月15日 14时51分
 * ALL RIGHTS ARESERVED！ 
 * 版权所有！
 */

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
        bool havePoint = false; // 记录是否已有小数点
        char op = ' ';
        public Form1()
        {
            InitializeComponent();


            this.textBox2.Text = "0";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 1) return;
            if (this.textBox2.Text[this.textBox2.Text.Length - 1] == '.') havePoint = false;
            this.textBox2.Text = this.textBox2.Text.Substring(0, this.textBox2.Text.Length - 1);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "0";
            this.textBox1.Text = "0";
        }

        private void Button19_Click(object sender, EventArgs e)
        {

        }

        private void Button20_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length > 0)
            {
                op = '/';
            }
            else
            {
                this.textBox1.Text = this.textBox2.Text;
                this.textBox2.Text = "0";
                op = '/';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "1";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "2";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "3";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "4";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "5";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "6";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "7";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "8";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "9";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length == 0 || this.textBox2.Text[0] == '0') this.textBox2.Text = "";
            this.textBox2.Text += "0";
        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (!havePoint)
            {
                this.textBox2.Text += ".";
                havePoint = true;
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            double a, b, c;
            switch (op)
            {
                case '/':
                    // 开始计算除法
                    a = double.Parse(this.textBox1.Text);
                    b = double.Parse(this.textBox2.Text);
                    c = a / b;
                    this.textBox1.Text = c.ToString();
                    this.textBox2.Text = "0";
                    op = ' ';
                    break;
                case '*':
                    // 开始计算除法
                    a = double.Parse(this.textBox1.Text);
                    b = double.Parse(this.textBox2.Text);
                    c = a * b;
                    this.textBox1.Text = c.ToString();
                    this.textBox2.Text = "0";
                    op = ' ';
                    break;
                case ' ':
                    this.textBox1.Text = this.textBox2.Text;
                    this.textBox2.Text = "0";
                    break;
                case '+':
                    // 开始计算除法
                    a = double.Parse(this.textBox1.Text);
                    b = double.Parse(this.textBox2.Text);
                    c = a + b;
                    this.textBox1.Text = c.ToString();
                    this.textBox2.Text = "0";
                    op = ' ';
                    break;
                case '-':
                    // 开始计算除法
                    a = double.Parse(this.textBox1.Text);
                    b = double.Parse(this.textBox2.Text);
                    c = a - b;
                    this.textBox1.Text = c.ToString();
                    this.textBox2.Text = "0";
                    op = ' ';
                    break;
                case '^':
                    this.textBox1.Text = Math.Pow(double.Parse(this.textBox1.Text), double.Parse(this.textBox2.Text)).ToString();
                    this.textBox2.Text = "0";
                    op = ' ';
                    break;


            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length > 0)
            {
                op = '*';
            }
            else
            {
                this.textBox1.Text = this.textBox2.Text;
                this.textBox2.Text = "0";
                op = '*';
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length > 0)
            {
                op = '-';
            }
            else
            {
                this.textBox1.Text = this.textBox2.Text;
                this.textBox2.Text = "0";
                op = '-';
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length > 0)
            {
                op = '+';
            }
            else
            {
                this.textBox1.Text = this.textBox2.Text;
                this.textBox2.Text = "0";
                op = '+';
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Math.Sqrt(double.Parse(this.textBox2.Text)).ToString();
            this.textBox2.Text = "0";
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            if(this.textBox2.Text.Length>0 && this.textBox1.Text.Length > 0)
            {
                this.textBox1.Text = Math.Pow(double.Parse(this.textBox1.Text), double.Parse(this.textBox2.Text)).ToString();
                this.textBox2.Text = "0";
                op = '^';
            }
            else
            {
                if(this.textBox1.Text.Length<1 && this.textBox2.Text.Length > 0)
                {
                    this.textBox1.Text = this.textBox2.Text;
                    this.textBox2.Text = "0";
                    op = '^';
                }
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Math.Log(double.Parse(this.textBox2.Text)).ToString();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Math.Sin(double.Parse(this.textBox2.Text)).ToString();
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Math.Cos(double.Parse(this.textBox2.Text)).ToString();

        }

        private void Button26_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Math.Tan(double.Parse(this.textBox2.Text)).ToString();
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            double tmp = 1;
            int n = int.Parse(this.textBox2.Text);
            for(int i = 1; i < n; i++)
            {
                tmp *= i;
            }
            this.textBox2.Text = tmp.ToString();
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Math.Sinh(double.Parse(this.textBox2.Text)).ToString();

        }

        private void Button29_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Math.Cosh(double.Parse(this.textBox2.Text)).ToString();

        }

        private void Button30_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Math.Tanh(double.Parse(this.textBox2.Text)).ToString();

        }
    }
}
