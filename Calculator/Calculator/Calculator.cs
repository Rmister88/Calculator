using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double pri;
        double seg;
        string op;
        public Calculator()
        {
            InitializeComponent();
        }
        Clases.Clssuma obj = new Clases.Clssuma();
        Clases.Clsresta obj2 = new Clases.Clsresta();
        Clases.Clsmultiplicacion obj3 = new Clases.Clsmultiplicacion();
        Clases.Clsdivision obj4 = new Clases.Clsdivision();
        Clases.Clsporcentaje obj5 = new Clases.Clsporcentaje();
        private void Button1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e3)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void TxtScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            op = "+";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            op = "-";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            op = "*" +
                "";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            op = "/";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            op = "%";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
            seg = double.Parse(tbxScreen.Text);

            double su;
            double re;
            double mu;
            double di;
            double po;

            switch (op)
            {
                case "+":
                    su = obj.Sumar((pri), (seg));
                    tbxScreen.Text = su.ToString();
                    break;
                case "-":
                    re = obj2.Restar((pri), (seg));
                    tbxScreen.Text = re.ToString();
                    break;
                case "*":
                    mu = obj3.Multiplicar((pri), (seg));
                    tbxScreen.Text = mu.ToString();
                    break;
                case "/":
                    di = obj4.Dividir((pri), (seg));
                    tbxScreen.Text = di.ToString();
                    break;
                case "%":
                    po = obj5.Porcentaje((pri), (seg));
                    tbxScreen.Text = po.ToString();
                    break;

            }
        }

        private void Btnborrar_Click(object sender, EventArgs e)
        {
            {
                if (tbxScreen.Text.Length == 1)
                    tbxScreen.Text = "";
                else
                    tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);

            }
        }

        private void Btnborrartodo_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }
    }
}
