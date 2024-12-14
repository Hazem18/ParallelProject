namespace GUI
{
    partial class quizPage
    {
        private System.ComponentModel.IContainer components = null;
        private Label quizTitleLabel;
        private Button buttonSubmitQuiz;
        private FlowLayoutPanel questionsFlowPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.quizTitleLabel = new Label();
            this.buttonSubmitQuiz = new Button();
            this.questionsFlowPanel = new FlowLayoutPanel();

            this.SuspendLayout();

            // quizTitleLabel
            this.quizTitleLabel.AutoSize = true;
            this.quizTitleLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            this.quizTitleLabel.ForeColor = Color.DarkSlateGray;
            this.quizTitleLabel.Location = new Point(20, 20);
            this.quizTitleLabel.Name = "quizTitleLabel";
            this.quizTitleLabel.Size = new Size(160, 42);
            this.quizTitleLabel.TabIndex = 0;
            this.quizTitleLabel.Text = "Quiz Title";

            // buttonSubmitQuiz
            this.buttonSubmitQuiz.BackColor = Color.DarkSlateGray;
            this.buttonSubmitQuiz.Font = new Font("Arial", 12F, FontStyle.Bold);
            this.buttonSubmitQuiz.ForeColor = Color.White;
            this.buttonSubmitQuiz.Location = new Point(250, 500);
            this.buttonSubmitQuiz.Name = "buttonSubmitQuiz";
            this.buttonSubmitQuiz.Size = new Size(150, 50);
            this.buttonSubmitQuiz.TabIndex = 1;
            this.buttonSubmitQuiz.Text = "Submit";
            this.buttonSubmitQuiz.UseVisualStyleBackColor = false;
            this.buttonSubmitQuiz.Click += new EventHandler(this.ButtonSubmitQuiz_Click);

            // questionsFlowPanel
            this.questionsFlowPanel.AutoScroll = true;
            this.questionsFlowPanel.Location = new Point(20, 80);
            this.questionsFlowPanel.Name = "questionsFlowPanel";
            this.questionsFlowPanel.Size = new Size(550, 400);
            this.questionsFlowPanel.TabIndex = 2;

            // quizPage
            this.ClientSize = new Size(600, 600);
            this.Controls.Add(this.quizTitleLabel);
            this.Controls.Add(this.buttonSubmitQuiz);
            this.Controls.Add(this.questionsFlowPanel);
            this.Name = "quizPage";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
