namespace GUI
{
    partial class quizPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            QuestionField = new Panel();
            label2 = new Label();
            label3 = new Label();
            answer1Btn = new RadioButton();
            answer2Btn = new RadioButton();
            answer4Btn = new RadioButton();
            answer3Btn = new RadioButton();
            QuestionField.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(302, 19);
            label1.Name = "label1";
            label1.Size = new Size(206, 49);
            label1.TabIndex = 0;
            label1.Text = "Question 1";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(302, 494);
            button1.Name = "button1";
            button1.Size = new Size(206, 52);
            button1.TabIndex = 1;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // QuestionField
            // 
            QuestionField.BackColor = Color.FromArgb(20, 20, 20);
            QuestionField.Controls.Add(answer3Btn);
            QuestionField.Controls.Add(answer4Btn);
            QuestionField.Controls.Add(answer2Btn);
            QuestionField.Controls.Add(answer1Btn);
            QuestionField.Controls.Add(label3);
            QuestionField.Controls.Add(label2);
            QuestionField.Location = new Point(37, 84);
            QuestionField.Name = "QuestionField";
            QuestionField.Size = new Size(713, 360);
            QuestionField.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(685, 23);
            label2.TabIndex = 0;
            label2.Text = "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 1;
            label3.Text = "eeeeeeee";
            label3.Click += label3_Click;
            // 
            // answer1Btn
            // 
            answer1Btn.AutoSize = true;
            answer1Btn.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answer1Btn.ForeColor = Color.White;
            answer1Btn.Location = new Point(40, 141);
            answer1Btn.Name = "answer1Btn";
            answer1Btn.Size = new Size(108, 23);
            answer1Btn.TabIndex = 6;
            answer1Btn.TabStop = true;
            answer1Btn.Text = "First Answer";
            answer1Btn.UseVisualStyleBackColor = true;
            answer1Btn.CheckedChanged += answer1Btn_CheckedChanged;
            // 
            // answer2Btn
            // 
            answer2Btn.AutoSize = true;
            answer2Btn.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answer2Btn.ForeColor = Color.White;
            answer2Btn.Location = new Point(40, 188);
            answer2Btn.Name = "answer2Btn";
            answer2Btn.Size = new Size(123, 23);
            answer2Btn.TabIndex = 7;
            answer2Btn.TabStop = true;
            answer2Btn.Text = "Second Answer";
            answer2Btn.UseVisualStyleBackColor = true;
            // 
            // answer4Btn
            // 
            answer4Btn.AutoSize = true;
            answer4Btn.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answer4Btn.ForeColor = Color.White;
            answer4Btn.Location = new Point(40, 282);
            answer4Btn.Name = "answer4Btn";
            answer4Btn.Size = new Size(120, 23);
            answer4Btn.TabIndex = 8;
            answer4Btn.TabStop = true;
            answer4Btn.Text = "Fourth Answer";
            answer4Btn.UseVisualStyleBackColor = true;
            // 
            // answer3Btn
            // 
            answer3Btn.AutoSize = true;
            answer3Btn.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answer3Btn.ForeColor = Color.White;
            answer3Btn.Location = new Point(40, 235);
            answer3Btn.Name = "answer3Btn";
            answer3Btn.Size = new Size(113, 23);
            answer3Btn.TabIndex = 9;
            answer3Btn.TabStop = true;
            answer3Btn.Text = "Third Answer";
            answer3Btn.UseVisualStyleBackColor = true;
            // 
            // quizPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 575);
            Controls.Add(QuestionField);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "quizPage";
            Text = "quizPage";
            QuestionField.ResumeLayout(false);
            QuestionField.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel QuestionField;
        private Label label3;
        private Label label2;
        private RadioButton answer1Btn;
        private RadioButton answer3Btn;
        private RadioButton answer4Btn;
        private RadioButton answer2Btn;
    }
}