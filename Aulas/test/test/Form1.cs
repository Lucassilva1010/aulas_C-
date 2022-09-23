namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculadora c = new calculadora();

            c.numero1 = double.Parse(textBox1.Text);
            c.numero2 = double.Parse(textBox2.Text);
            c.Soma();
            label4.Text =  Convert.ToString(c.Soma()); 

        }
    }
}