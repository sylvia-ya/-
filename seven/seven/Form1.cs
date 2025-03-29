namespace seven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Int32.Parse(textBox1.Text);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    textBox2.Text += "¡¯";
                }
                textBox2.Text += "\r\n";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int len = Int32.Parse(textBox1.Text);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    textBox2.Text += "¡¯";
                }
                textBox2.Text += "\r\n";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int len = Int32.Parse(textBox1.Text);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    textBox2.Text += "¡@";
                }
                for (int j = 0; j < len - i; j++)
                {
                    textBox2.Text += "¡¯";
                }
                textBox2.Text += "\r\n";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int len = Int32.Parse(textBox1.Text);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    textBox2.Text += "¡@";
                }
                for (int j = 0; j < i + 1; j++)
                {
                    textBox2.Text += "¡¯";
                }
                textBox2.Text += "\r\n";

            }
        }
    }
}