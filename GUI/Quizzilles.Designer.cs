namespace GUI
{
    partial class Quizzilles
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
            Login = new Button();
            label1 = new Label();
            Signup = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Location = new Point(51, 314);
            Login.Name = "Login";
            Login.Size = new Size(233, 36);
            Login.TabIndex = 0;
            Login.Text = "Yes";
            Login.UseVisualStyleBackColor = true;
            Login.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(194, 215);
            label1.Name = "label1";
            label1.Size = new Size(232, 38);
            label1.TabIndex = 1;
            label1.Text = "Have an account";
            label1.Click += label1_Click;
            // 
            // Signup
            // 
            Signup.Location = new Point(319, 314);
            Signup.Name = "Signup";
            Signup.Size = new Size(233, 36);
            Signup.TabIndex = 2;
            Signup.Text = "No";
            Signup.UseVisualStyleBackColor = true;
            Signup.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(98, 73);
            label2.Name = "label2";
            label2.Size = new Size(417, 51);
            label2.TabIndex = 3;
            label2.Text = "Welcome to Quizzilles";
            label2.Click += label2_Click;
            // 
            // Quizzilles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(634, 411);
            Controls.Add(label2);
            Controls.Add(Signup);
            Controls.Add(label1);
            Controls.Add(Login);
            Name = "Quizzilles";
            Text = "Quizzilles";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Label label1;
        private Button Signup;
        private Label label2;
    }
}
