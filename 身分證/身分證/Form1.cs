namespace 身分證
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isTrueID(string id)
        {
            // 判斷字串長度是否為10
            if (id.Length != 10)
            {
                MessageBox.Show("長度不為10");
            }
            // 判斷第一個字元是否為英文字母
            char firstid = id[0];
            if (!Char.IsLetter(firstid))
            {
                MessageBox.Show("第1碼不為英文字母");
            }
            // 判斷後9碼是否為數字
            string number1 = id.Substring(1);
            if (!long.TryParse(number1, out _))
            {
                MessageBox.Show("後9碼不為數字");
            }


            int[] lettermap = new int[]
            {
        10,11,12,13,14,15,16,17,34,18,19,20,21,22,35,23,24,25,26,27,28,29,32,30,31,33
            };

            int lettervalue = lettermap[Char.ToUpper(firstid) - 'A'];
            int sum = (lettervalue / 10 + (lettervalue % 10) * 9) % 10;

            int[] weight = { 8, 7, 6, 5, 4, 3, 2, 1, 1 };
            for (int i = 0; i < 9; i++)
            {
                // id[i+1]-'0' 轉為數字型態
                sum += (id[i + 1] - '0') * weight[i]; // B12066750 3 id[i+1] ==1
            }

            return sum % 10 == 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            textBox2.Text="";
        }
    }
}