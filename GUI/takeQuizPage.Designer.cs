namespace GUI
{
    partial class takeQuizPage
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            StartBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(101, 116);
            label1.Name = "label1";
            label1.Size = new Size(418, 45);
            label1.TabIndex = 1;
            label1.Text = "Click Here To Start Quiz";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.Black;
            StartBtn.BackgroundImageLayout = ImageLayout.Stretch;
            StartBtn.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartBtn.ForeColor = SystemColors.Control;
            StartBtn.Location = new Point(141, 247);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(325, 46);
            StartBtn.TabIndex = 2;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // takeQuizPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wallpaper;
            ClientSize = new Size(634, 411);
            Controls.Add(StartBtn);
            Controls.Add(label1);
            Name = "takeQuizPage";
            Text = "takeQuizPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button StartBtn;
    }
}