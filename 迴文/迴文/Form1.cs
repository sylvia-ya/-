namespace 迴文
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool IsPalindrome(string input)
        {
            string reverseinput = new string(input.Reverse().ToArray());
            return input == reverseinput;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (IsPalindrome(input))
            {
                textBox2.Text = "是迴文";
            }
            else
            {
                textBox2.Text = "不是迴文";
            }
        }
    }
}