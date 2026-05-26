namespace TempConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double input;

            if (!double.TryParse(textBox1.Text, out input))
            {
                MessageBox.Show("結果：請輸入正確數字");
                return;
            }

            if (radioButton1.Checked)
            {
                double f = input * 9 / 5 + 32;
                label1.Visible= true;
                label1.Text = $"結果：{input}°C = {f}°F";
            }
            else
            {
                double c = (input - 32) * 5 / 9;
                label1.Visible = true;
                label1.Text = $"結果：{input}°F = {c:F1}°C";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "結果：";
            textBox1.Focus();
        }
    }
}
