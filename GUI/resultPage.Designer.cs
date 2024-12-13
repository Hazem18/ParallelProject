namespace GUI
{
    partial class resultPage
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
            Grade = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 183);
            label1.Name = "label1";
            label1.Size = new Size(317, 40);
            label1.TabIndex = 0;
            label1.Text = "Your Final Result is: ";
            // 
            // Grade
            // 
            Grade.AutoSize = true;
            Grade.BackColor = Color.Transparent;
            Grade.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Grade.ForeColor = Color.White;
            Grade.Location = new Point(427, 183);
            Grade.Name = "Grade";
            Grade.Size = new Size(77, 40);
            Grade.TabIndex = 1;
            Grade.Text = "95%";
            // 
            // resultPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wallpaper;
            ClientSize = new Size(634, 411);
            Controls.Add(Grade);
            Controls.Add(label1);
            Name = "resultPage";
            Text = "resultPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Grade;
    }
}