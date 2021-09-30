using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        decimal valorum = 0, valordois = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text +=  "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valordois = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "Adicao")
            {
                txtResultado.Text = Convert.ToString(valorum + valordois);
            }
            else if(operacao == "Subtracao")
            {
                txtResultado.Text = Convert.ToString(valorum - valordois);
            }
            else if (operacao == "Multiplicacao")
            {
                txtResultado.Text = Convert.ToString(valorum * valordois);
            }
            else if (operacao == "Divisao")
            {
                txtResultado.Text = Convert.ToString(valorum / valordois);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (txtResultado.Text != "")
            {
                valorum = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Subtracao";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor válido primeiro!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            if (txtResultado.Text != "")
            {
                valorum = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Multiplicacao";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor válido primeiro!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            if (txtResultado.Text != "")
            {
                valorum = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Divisao";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor válido primeiro!");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valorum = 0;
            valordois = 0;
            lblOperacao.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valorum = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Adicao";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor válido primeiro!");
            }
            
            
        }
    }
}
