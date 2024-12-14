// AddQuiz.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ParallelProject.Models;
using ParallelProject.Services;

namespace GUI
{
    public partial class AddQuiz : Form
    {
        private readonly QuizService _quizService;
        private readonly List<Question> _questions;

        public AddQuiz(QuizService quizService)
        {
            InitializeComponent();
            _quizService = quizService;
            _questions = new List<Question>();
        }

        private void BtnAddQuestion_Click(object sender, EventArgs e)
        {
            string questionText = txtQuestion.Text.Trim();
            string optionA = txtOptionA.Text.Trim();
            string optionB = txtOptionB.Text.Trim();
            string optionC = txtOptionC.Text.Trim();
            string optionD = txtOptionD.Text.Trim();
            string correctOption = cmbCorrectOption.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(optionA) ||
                string.IsNullOrEmpty(optionB) || string.IsNullOrEmpty(optionC) ||
                string.IsNullOrEmpty(optionD) || string.IsNullOrEmpty(correctOption))
            {
                MessageBox.Show("Please fill in all fields and select the correct option.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var question = new Question
            {
                Text = questionText,
                OptionA = optionA,
                OptionB = optionB,
                OptionC = optionC,
                OptionD = optionD,
                CorrectOption = correctOption
            };

            _questions.Add(question);
            lstQuestions.Items.Add($"Q: {questionText}");
            txtQuestion.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            cmbCorrectOption.SelectedIndex = -1;
        }

        private async void BtnSaveQuiz_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Quiz title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var quiz = new Quiz
            {
                Title = title,
                Description = description,
                Questions = _questions
            };

            try
            {
                await _quizService.CreateQuizAsync(quiz);
                MessageBox.Show("Quiz saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving quiz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
