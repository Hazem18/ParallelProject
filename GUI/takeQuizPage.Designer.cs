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
            QuizDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(QuizDataGridView)).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(101, 370);
            label1.Name = "label1";
            label1.Size = new Size(521, 55);
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
            StartBtn.Location = new Point(155, 460);
            StartBtn.Margin = new Padding(3, 4, 3, 4);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(371, 61);
            StartBtn.TabIndex = 2;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // QuizDataGridView
            // 
            QuizDataGridView.AllowUserToAddRows = false;
            QuizDataGridView.AllowUserToDeleteRows = false;
            QuizDataGridView.AllowUserToResizeColumns = false;
            QuizDataGridView.AllowUserToResizeRows = false;
            QuizDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuizDataGridView.Columns.AddRange(new DataGridViewColumn[] {
            new DataGridViewTextBoxColumn() { Name = "QuizId", HeaderText = "Quiz ID", Width = 100 },
            new DataGridViewTextBoxColumn() { Name = "QuizTitle", HeaderText = "Quiz Title", Width = 300 }
            });
            QuizDataGridView.Location = new Point(12, 12);
            QuizDataGridView.Name = "QuizDataGridView";
            QuizDataGridView.ReadOnly = true;
            QuizDataGridView.RowHeadersWidth = 51;
            QuizDataGridView.RowTemplate.Height = 29;
            QuizDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            QuizDataGridView.Size = new Size(700, 250);
            QuizDataGridView.TabIndex = 3;
            QuizDataGridView.CellClick += QuizDataGridView_CellClick;
            // 
            // takeQuizPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wallpaper;
            ClientSize = new Size(725, 548);
            Controls.Add(QuizDataGridView);
            Controls.Add(StartBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "takeQuizPage";
            Text = "Take Quiz Page";
            Load += takeQuizPage_Load;
            ((System.ComponentModel.ISupportInitialize)(QuizDataGridView)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button StartBtn;
        private DataGridView QuizDataGridView;
    }
}
