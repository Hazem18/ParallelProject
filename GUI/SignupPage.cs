using Microsoft.EntityFrameworkCore;
using ParallelProject.Data;
using ParallelProject.Models;
using ParallelProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SignupPage : Form
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public SignupPage(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            InitializeComponent();
            _dbContextFactory = dbContextFactory;
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect user input
                string userName = UserFiled.Text;
                string password = PasswordFiled.Text;
                int roleid = Int32.Parse(RoleIDtxt.Text);


                // Create a new User object
                User newUser = new User
                {
                    Name = userName,
                    Password = password,
                    RoleId =roleid
                };

                var userService = new UserService(_dbContextFactory);
                await userService.RegisterAsync(newUser);

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginPage login = new(_dbContextFactory);
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Show the exception details
                MessageBox.Show($"Registration failed: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
