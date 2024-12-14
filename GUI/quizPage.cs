using ParallelProject.Services;
using ParallelProject.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class quizPage : Form
    {
        private readonly QuizService _quizService;
        private readonly ResultService _resultService;
        private readonly int _quizId;
        private readonly int userId;

        public quizPage(QuizService quizService, ResultService resultService, int quizId, int _userId)
        {
            InitializeComponent();
            _quizService = quizService;
            _resultService = resultService;
            _quizId = quizId;
            userId=_userId;
            LoadQuizQuestionsAsync();
        }

        private async void LoadQuizQuestionsAsync()
        {
            try
            {
                // Fetch the questions for the selected quiz from the QuizService
                var questions = await _quizService.GetQuestionsForQuizAsync(_quizId);
                quizTitleLabel.Text = $"Quiz ID: {_quizId}"; // Set the quiz title or ID

                // Clear the previous questions (if any)
                questionsFlowPanel.Controls.Clear();

                foreach (var question in questions)
                {
                    // Create a new GroupBox for each question
                    var questionGroupBox = new GroupBox
                    {
                        Text = question.Text,
                        Font = new Font("Arial", 12F, FontStyle.Bold),
                        ForeColor = Color.White,
                        BackColor = Color.LightSlateGray,
                        Size = new Size(500, 200), // Increased the height to fit options
                        Padding = new Padding(10),
                        Tag = question.Id // Store the Question ID for later use
                    };

                    // Create radio buttons for each answer option
                    var optionA = new RadioButton
                    {
                        Text = question.OptionA,
                        Font = new Font("Arial", 10F),
                        Dock = DockStyle.Top,
                        Padding = new Padding(5),
                        AutoSize = true,
                        Tag = "A" // Tag to identify the option
                    };
                    var optionB = new RadioButton
                    {
                        Text = question.OptionB,
                        Font = new Font("Arial", 10F),
                        Dock = DockStyle.Top,
                        Padding = new Padding(5),
                        AutoSize = true,
                        Tag = "B"
                    };
                    var optionC = new RadioButton
                    {
                        Text = question.OptionC,
                        Font = new Font("Arial", 10F),
                        Dock = DockStyle.Top,
                        Padding = new Padding(5),
                        AutoSize = true,
                        Tag = "C"
                    };
                    var optionD = new RadioButton
                    {
                        Text = question.OptionD,
                        Font = new Font("Arial", 10F),
                        Dock = DockStyle.Top,
                        Padding = new Padding(5),
                        AutoSize = true,
                        Tag = "D"
                    };

                    // Add the radio buttons to the GroupBox
                    questionGroupBox.Controls.Add(optionA);
                    questionGroupBox.Controls.Add(optionB);
                    questionGroupBox.Controls.Add(optionC);
                    questionGroupBox.Controls.Add(optionD);

                    // Add the question GroupBox to the FlowLayoutPanel
                    questionsFlowPanel.Controls.Add(questionGroupBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quiz questions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ButtonSubmitQuiz_Click(object sender, EventArgs e)
        {
            try
            {
                // Prepare the list of user answers
                var userAnswers = new List<Answer>();

                foreach (GroupBox groupBox in questionsFlowPanel.Controls)
                {
                    var questionId = (int)groupBox.Tag; // Retrieve the Question ID

                    // Find the selected radio button
                    var selectedOption = groupBox.Controls.OfType<RadioButton>()
                        .FirstOrDefault(rb => rb.Checked);

                    if (selectedOption != null)
                    {
                        var selectedChoice = selectedOption.Tag.ToString();

                        // Map selected option to index (0 = A, 1 = B, etc.)
                        int selectedIndex = selectedChoice switch
                        {
                            "A" => 0,
                            "B" => 1,
                            "C" => 2,
                            "D" => 3,
                            _ => -1
                        };

                        // Add the answer to the list
                        userAnswers.Add(new Answer
                        {
                            QuestionId = questionId,
                            SelectedChoiceIndex = selectedIndex
                        });
                    }
                }

                // Submit the result with the associated userId
                //await _resultService.StoreQuizResultAsync(_userId, _quizId, userAnswers);

                // Fetch the questions for the quiz
                var questions = await _quizService.GetQuestionsForQuizAsync(_quizId);

                // Calculate the score using ResultService
                int score = await _resultService.CalculateScoreAsync(questions, userAnswers);

                // Save the result to the database
                var quizResult = new QuizResult
                {
                    UserId = userId, // Replace with actual user ID
                    Quiz_Id = _quizId,
                    Score = score,
                    Answers = userAnswers
                };

                await _resultService.SubmitQuizResultAsync(quizResult);

                MessageBox.Show("Quiz submitted successfully!"+$"Score: {score} ", "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting quiz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
