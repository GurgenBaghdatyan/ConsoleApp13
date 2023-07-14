using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Operations operations = new Operations();
        double x;
        bool plus = false;
        bool minus = false;
        bool bazmapatkum = false;
        bool bajanum = false;
        bool equal = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "3";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "5";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "9";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (equal) textBox1.Text = string.Empty;
            equal = false;
            textBox1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            minus = true;
            plus = false;
            bazmapatkum = false;
            bajanum = false;
            textBox1.Text = string.Empty;
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            minus = false;
            plus = true;
            bazmapatkum = false;
            bajanum = false;
            textBox1.Text = string.Empty;
        }
        private void buttonBazmapatkum_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            minus = false;
            plus = false;
            bazmapatkum = true;
            bajanum = false;
            textBox1.Text = string.Empty;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            minus = false;
            plus = false;
            bazmapatkum = false;
            bajanum = true;
            textBox1.Text = string.Empty;
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double y = Convert.ToDouble(textBox1.Text);
            if (minus) { textBox1.Text = Convert.ToString(operations.Minus(x, y)); }
            else if (plus) { textBox1.Text = Convert.ToString(operations.Plus(x, y)); }
            else if (bazmapatkum) { textBox1.Text = Convert.ToString(operations.Bazmapatkum(x, y)); }
            else if (bajanum) { textBox1.Text = Convert.ToString(operations.Bajanum(x, y)); }
            equal = true;

        }
        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}