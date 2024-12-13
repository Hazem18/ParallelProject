namespace GUI
{
    partial class SignupPage
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
            SubmitBtn = new Button();
            PasswordLabel = new Label();
            UserLable = new Label();
            UserFiled = new TextBox();
            PasswordFiled = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // SubmitBtn
            // 
            SubmitBtn.AutoSize = true;
            SubmitBtn.BackColor = Color.Transparent;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = Color.Transparent;
            SubmitBtn.Location = new Point(199, 304);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(215, 46);
            SubmitBtn.TabIndex = 8;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(108, 226);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(94, 23);
            PasswordLabel.TabIndex = 7;
            PasswordLabel.Text = "Password: ";
            // 
            // UserLable
            // 
            UserLable.AutoSize = true;
            UserLable.BackColor = Color.Transparent;
            UserLable.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLable.ForeColor = Color.White;
            UserLable.Location = new Point(108, 150);
            UserLable.Name = "UserLable";
            UserLable.Size = new Size(99, 23);
            UserLable.TabIndex = 4;
            UserLable.Text = "Username: ";
            // 
            // UserFiled
            // 
            UserFiled.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserFiled.ForeColor = SystemColors.ScrollBar;
            UserFiled.Location = new Point(213, 150);
            UserFiled.Name = "UserFiled";
            UserFiled.Size = new Size(283, 26);
            UserFiled.TabIndex = 6;
            // 
            // PasswordFiled
            // 
            PasswordFiled.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordFiled.ForeColor = SystemColors.WindowFrame;
            PasswordFiled.Location = new Point(213, 227);
            PasswordFiled.Multiline = true;
            PasswordFiled.Name = "PasswordFiled";
            PasswordFiled.Size = new Size(283, 26);
            PasswordFiled.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(199, 51);
            label1.Name = "label1";
            label1.Size = new Size(224, 45);
            label1.TabIndex = 9;
            label1.Text = "Sign Up Page";
            // 
            // SignupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(634, 411);
            Controls.Add(label1);
            Controls.Add(SubmitBtn);
            Controls.Add(PasswordLabel);
            Controls.Add(UserLable);
            Controls.Add(UserFiled);
            Controls.Add(PasswordFiled);
            Name = "SignupPage";
            Text = "SignupPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitBtn;
        private Label PasswordLabel;
        private Label UserLable;
        private TextBox UserFiled;
        private TextBox PasswordFiled;
        private Label label1;
    }
}