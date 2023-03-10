using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            error1.SetError(Wynik, null);
            double a, b;
            if (INT.Checked == true)
            {
                int c, d;
                try
                {
                    c = Convert.ToInt32(textBox1.Text);
                }
                catch
                {
                    error1.SetError(Wynik, "Wrong");
                    return;
                }

                try
                {
                    d = Convert.ToInt32(textBox2.Text);
                }
                catch
                {
                    error1.SetError(Wynik, "Wrong");
                    return;
                }
                if (Dodawanie.Checked == true)
                    Wynik.Text = Convert.ToString(c + d);
                if (Odejmowaie.Checked == true)
                    Wynik.Text = Convert.ToString(c - d);
                if (Mnozenie.Checked == true)
                    Wynik.Text = Convert.ToString(c * d);
                if (Dzielenie.Checked == true)
                {
                    if (d == 0)
                        error1.SetError(Wynik, "Wrong");
                    else
                        Wynik.Text = Convert.ToString(c / d);
                }

            }
            else
            {
                try
                {
                    a = Convert.ToDouble(textBox1.Text);
                }
                catch
                {
                    error1.SetError(Wynik, "Wrong");
                    return;
                }

                try
                {
                    b = Convert.ToDouble(textBox2.Text);
                }
                catch
                {
                    error1.SetError(Wynik, "Wrong");
                    return;
                }
                if (Dodawanie.Checked == true)
                    Wynik.Text = Convert.ToString(a + b);
                if (Odejmowaie.Checked == true)
                    Wynik.Text = Convert.ToString(a - b);
                if (Mnozenie.Checked == true)
                    Wynik.Text = Convert.ToString(a * b);
                if (Dzielenie.Checked == true)
                {
                    if (b == 0)
                        error1.SetError(Wynik, "Wrong");
                    else
                        Wynik.Text = Convert.ToString(a / b);
                }
            }


            

            }

        private void Dodawanie_CheckedChanged(object sender, EventArgs e)
        {
            error1.SetError(Wynik, null);
            Wynik.Text = "";
        }

        private void Odejmowaie_CheckedChanged(object sender, EventArgs e)
        {
            error1.SetError(Wynik, null);
            Wynik.Text = "";
        }

        private void Mnozenie_CheckedChanged(object sender, EventArgs e)
        {
            error1.SetError(Wynik, null);
            Wynik.Text = "";
        }

        private void Dzielenie_CheckedChanged(object sender, EventArgs e)
        {
            error1.SetError(Wynik, null);
            Wynik.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            error1.SetError(Wynik, null);
            Wynik.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            error1.SetError(Wynik, null);
            Wynik.Text = "";
        }

        private void OK_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK_Click(this, new EventArgs());
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    OK_Click(this, new EventArgs());
                }
        }

        private void Dzielenie_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    OK_Click(this, new EventArgs());
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
