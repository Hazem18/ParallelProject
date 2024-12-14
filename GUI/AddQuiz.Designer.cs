// AddQuiz.Designer.cs
using System;
using System.Windows.Forms;

namespace GUI
{
    partial class AddQuiz
    {
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnAddQuestion;
        private Button btnSaveQuiz;
        private ListBox lstQuestions;
        private TextBox txtQuestion;
        private Label lblOptionA;
        private Label lblOptionB;
        private Label lblOptionC;
        private Label lblOptionD;
        private Label lblCorrectOption;
        private TextBox txtOptionA;
        private TextBox txtOptionB;
        private TextBox txtOptionC;
        private TextBox txtOptionD;
        private ComboBox cmbCorrectOption;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAddQuestion = new Button();
            btnSaveQuiz = new Button();
            lstQuestions = new ListBox();
            txtQuestion = new TextBox();
            lblOptionA = new Label();
            lblOptionB = new Label();
            lblOptionC = new Label();
            lblOptionD = new Label();
            lblCorrectOption = new Label();
            txtOptionA = new TextBox();
            txtOptionB = new TextBox();
            txtOptionC = new TextBox();
            txtOptionD = new TextBox();
            cmbCorrectOption = new ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quiz Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(120, 20);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(20, 60);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 60);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 27);
            txtDescription.TabIndex = 3;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(20, 340);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(75, 23);
            btnAddQuestion.TabIndex = 15;
            btnAddQuestion.Text = "Add Question";
            btnAddQuestion.Click += BtnAddQuestion_Click;
            // 
            // btnSaveQuiz
            // 
            btnSaveQuiz.Location = new Point(20, 500);
            btnSaveQuiz.Name = "btnSaveQuiz";
            btnSaveQuiz.Size = new Size(75, 23);
            btnSaveQuiz.TabIndex = 17;
            btnSaveQuiz.Text = "Save Quiz";
            btnSaveQuiz.Click += BtnSaveQuiz_Click;
            // 
            // lstQuestions
            // 
            lstQuestions.Location = new Point(20, 380);
            lstQuestions.Name = "lstQuestions";
            lstQuestions.Size = new Size(300, 84);
            lstQuestions.TabIndex = 16;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(20, 100);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.PlaceholderText = "Enter the question...";
            txtQuestion.Size = new Size(300, 27);
            txtQuestion.TabIndex = 4;
            // 
            // lblOptionA
            // 
            lblOptionA.Location = new Point(20, 140);
            lblOptionA.Name = "lblOptionA";
            lblOptionA.Size = new Size(100, 23);
            lblOptionA.TabIndex = 5;
            lblOptionA.Text = "Option A:";
            // 
            // lblOptionB
            // 
            lblOptionB.Location = new Point(20, 180);
            lblOptionB.Name = "lblOptionB";
            lblOptionB.Size = new Size(100, 23);
            lblOptionB.TabIndex = 7;
            lblOptionB.Text = "Option B:";
            // 
            // lblOptionC
            // 
            lblOptionC.Location = new Point(20, 220);
            lblOptionC.Name = "lblOptionC";
            lblOptionC.Size = new Size(100, 23);
            lblOptionC.TabIndex = 9;
            lblOptionC.Text = "Option C:";
            // 
            // lblOptionD
            // 
            lblOptionD.Location = new Point(20, 260);
            lblOptionD.Name = "lblOptionD";
            lblOptionD.Size = new Size(100, 23);
            lblOptionD.TabIndex = 11;
            lblOptionD.Text = "Option D:";
            // 
            // lblCorrectOption
            // 
            lblCorrectOption.Location = new Point(20, 300);
            lblCorrectOption.Name = "lblCorrectOption";
            lblCorrectOption.Size = new Size(100, 23);
            lblCorrectOption.TabIndex = 13;
            lblCorrectOption.Text = "Correct Option:";
            // 
            // txtOptionA
            // 
            txtOptionA.Location = new Point(120, 140);
            txtOptionA.Name = "txtOptionA";
            txtOptionA.Size = new Size(200, 27);
            txtOptionA.TabIndex = 6;
            // 
            // txtOptionB
            // 
            txtOptionB.Location = new Point(120, 180);
            txtOptionB.Name = "txtOptionB";
            txtOptionB.Size = new Size(200, 27);
            txtOptionB.TabIndex = 8;
            // 
            // txtOptionC
            // 
            txtOptionC.Location = new Point(120, 220);
            txtOptionC.Name = "txtOptionC";
            txtOptionC.Size = new Size(200, 27);
            txtOptionC.TabIndex = 10;
            // 
            // txtOptionD
            // 
            txtOptionD.Location = new Point(120, 260);
            txtOptionD.Name = "txtOptionD";
            txtOptionD.Size = new Size(200, 27);
            txtOptionD.TabIndex = 12;
            // 
            // cmbCorrectOption
            // 
            cmbCorrectOption.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cmbCorrectOption.Location = new Point(120, 300);
            cmbCorrectOption.Name = "cmbCorrectOption";
            cmbCorrectOption.Size = new Size(200, 28);
            cmbCorrectOption.TabIndex = 14;
            // 
            // AddQuiz
            // 
            ClientSize = new Size(882, 560);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(txtQuestion);
            Controls.Add(lblOptionA);
            Controls.Add(txtOptionA);
            Controls.Add(lblOptionB);
            Controls.Add(txtOptionB);
            Controls.Add(lblOptionC);
            Controls.Add(txtOptionC);
            Controls.Add(lblOptionD);
            Controls.Add(txtOptionD);
            Controls.Add(lblCorrectOption);
            Controls.Add(cmbCorrectOption);
            Controls.Add(btnAddQuestion);
            Controls.Add(lstQuestions);
            Controls.Add(btnSaveQuiz);
            Name = "AddQuiz";
            Text = "Add Quiz";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
