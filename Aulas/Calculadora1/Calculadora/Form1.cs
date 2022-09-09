using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();//finaliza o programa - Sai do programa - Encerra o Pograma
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int numero1, numero2;
            double resultado;

            numero1 = int.Parse(textBox1.Text);
            //numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = int.Parse(textBox2.Text);
            //numero1 = Convert.ToInt32(textBox2.Text);

            resultado = numero1 + numero2;

            label4.Text = Convert.ToString( resultado);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
