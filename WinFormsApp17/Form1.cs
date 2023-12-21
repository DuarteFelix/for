using System.Security.Cryptography.Xml;

namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int numero = Convert.ToInt32(textBox1.Text);

            label2.Text = ($"Tabuada do {numero}:");


            for (int i = 1; i <= 10; i++)
            {

                int resultado = numero * i;


                listBox1.Items.Add($"{numero} x {i} = {resultado}");
            }

        }
    }
}