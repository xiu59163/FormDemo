namespace GuessNum1A2B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnAnswer = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnCheck = new Button();
            btnRestart = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(37, 23);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(80, 35);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnAnswer
            // 
            btnAnswer.Location = new Point(37, 110);
            btnAnswer.Name = "btnAnswer";
            btnAnswer.Size = new Size(80, 35);
            btnAnswer.TabIndex = 1;
            btnAnswer.Text = "看答案";
            btnAnswer.UseVisualStyleBackColor = true;
            btnAnswer.Click += btnAnswer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 283);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "輸入";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 311);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 3;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(53, 356);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(80, 35);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "檢查答案";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(191, 356);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(80, 35);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "放棄重來";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 23);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "遊戲歷程";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(378, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(294, 379);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(btnRestart);
            Controls.Add(btnCheck);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnAnswer);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnAnswer;
        private Label label1;
        private TextBox textBox1;
        private Button btnCheck;
        private Button btnRestart;
        private Label label2;
        private ListBox listBox1;
    }
}
