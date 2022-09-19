using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_ParaFOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mesInvestimento, i = 1;
            double valorInvestimento, taxaInvestimento, taxaFinal;

            valorInvestimento = double.Parse(textBox1.Text);
            taxaInvestimento = double.Parse(textBox2.Text);
            taxaFinal = taxaInvestimento / 100;
            mesInvestimento = int.Parse(textBox3.Text);
           
            while (i <= mesInvestimento)
            {
                valorInvestimento = valorInvestimento + (valorInvestimento * taxaFinal);

               //label5.Text = "O valor do Investimento no "+i+"ª mês é de:"+ valorInvestimento.ToString();
                              
               // MessageBox.Show(" O valor de Investimento no  "+i+"ª mês é de: "+ valorInvestimento);
                listBox1.Items.Add(" O valor de Investimento no  " + i + "ª mês é de: " + valorInvestimento);
                i++;
                
            }


        }
    }
}
