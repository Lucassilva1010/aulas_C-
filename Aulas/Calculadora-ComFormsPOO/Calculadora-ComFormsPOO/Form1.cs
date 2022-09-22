namespace Calculadora_ComFormsPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            Calculadora n = new Calculadora();
            n.nun1 = double.Parse(textBoxNumero1.Text);
            n.nun2 = double.Parse(textBoxNumero2.Text);
            n.Soma();
            labelValorSaida.Text = Convert.ToString(n.Soma());
        }
    }
}