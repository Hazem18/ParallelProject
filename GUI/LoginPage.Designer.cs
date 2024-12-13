namespace GUI
{
    partial class LoginPage
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
            PasswordFiled = new TextBox();
            UserFiled = new TextBox();
            UserLable = new Label();
            PasswordLabel = new Label();
            SubmitBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // PasswordFiled
            // 
            PasswordFiled.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordFiled.ForeColor = SystemColors.MenuText;
            PasswordFiled.Location = new Point(212, 220);
            PasswordFiled.Multiline = true;
            PasswordFiled.Name = "PasswordFiled";
            PasswordFiled.Size = new Size(283, 26);
            PasswordFiled.TabIndex = 0;
            PasswordFiled.TextChanged += textBox1_TextChanged;
            // 
            // UserFiled
            // 
            UserFiled.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserFiled.ForeColor = SystemColors.MenuText;
            UserFiled.Location = new Point(212, 143);
            UserFiled.Name = "UserFiled";
            UserFiled.Size = new Size(283, 26);
            UserFiled.TabIndex = 1;
            UserFiled.TextChanged += UserFiled_TextChanged;
            // 
            // UserLable
            // 
            UserLable.AutoSize = true;
            UserLable.BackColor = Color.Transparent;
            UserLable.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLable.ForeColor = Color.White;
            UserLable.Location = new Point(107, 143);
            UserLable.Name = "UserLable";
            UserLable.Size = new Size(99, 23);
            UserLable.TabIndex = 0;
            UserLable.Text = "Username: ";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(107, 219);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(94, 23);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password: ";
            // 
            // SubmitBtn
            // 
            SubmitBtn.AutoSize = true;
            SubmitBtn.BackColor = Color.Transparent;
            SubmitBtn.FlatStyle = FlatStyle.Flat;
            SubmitBtn.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = Color.Transparent;
            SubmitBtn.Location = new Point(200, 308);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(215, 46);
            SubmitBtn.TabIndex = 3;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(212, 40);
            label1.Name = "label1";
            label1.Size = new Size(182, 45);
            label1.TabIndex = 4;
            label1.Text = "Login Page";
            // 
            // LoginPage
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
            Name = "LoginPage";
            Text = "Login";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordFiled;
        private TextBox UserFiled;
        private Label UserLable;
        private Label PasswordLabel;
        private Button SubmitBtn;
        private Label label1;
    }
}