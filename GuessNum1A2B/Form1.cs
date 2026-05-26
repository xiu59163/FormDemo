namespace GuessNum1A2B
{
    public partial class Form1 : Form
    {
        string answer = "";
        Random rnd = new Random();


        public Form1()
        {

            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            answer = GenerateAnswer();

            textBox1.Clear();
            listBox1.Items.Clear();

            textBox1.Enabled = true;
            btnCheck.Enabled = true;
            btnAnswer.Enabled = true;
            btnRestart.Enabled = true;

            textBox1.Focus();
        }
        private string GenerateAnswer()
        {
            //產生answer
            return string.Join("", Enumerable.Range(0, 10)
                .OrderBy(x => rnd.Next())
                .Take(4));
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text;

            if (!IsValidGuess(guess))
            {
                MessageBox.Show("請輸入 4 個不重複的數字");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            int a = 0;
            int b = 0;

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == answer[i])
                {
                    a++;
                }
                else if (answer.Contains(guess[i]))
                {
                    b++;
                }
            }

            listBox1.Items.Add($"{guess} : {a}A{b}B");

            if (a == 4)
            {
                MessageBox.Show("過關");

                textBox1.Enabled = false;
                btnCheck.Enabled = false;
            }
            btnStart.Enabled = false;
            textBox1.Clear();
            textBox1.Focus();
        }
        private bool IsValidGuess(string guess)
        {
            if (guess.Length != 4)
                return false;

            if (!guess.All(char.IsDigit))
                return false;

            if (guess.Distinct().Count() != 4)
                return false;

            return true;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案是：{answer}");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartGame();
            btnStart.Enabled = true;
        }
    }
}
