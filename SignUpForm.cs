using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "First name")
            {
                firstNameTextBox.Text = "";
                firstNameTextBox.ForeColor = Color.Black;
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                firstNameTextBox.Text = "First name";
                firstNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "Last name")
            {
                lastNameTextBox.Text = ""; // Clear placeholder
                lastNameTextBox.ForeColor = Color.Black; // Set text color for user input
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                lastNameTextBox.Text = "Last name"; // Restore placeholder
                lastNameTextBox.ForeColor = Color.Gray; // Set text color for placeholder
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email")
            {
                emailTextBox.Text = ""; // Clear placeholder
                emailTextBox.ForeColor = Color.Black; // Set text color for user input
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Text = "Email"; // Restore placeholder
                emailTextBox.ForeColor = Color.Gray; // Set text color for placeholder
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = ""; // Clear placeholder
                passwordTextBox.ForeColor = Color.Black; // Set text color for user input
                passwordTextBox.UseSystemPasswordChar = true; // Mask input
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Password"; // Restore placeholder
                passwordTextBox.ForeColor = Color.Gray; // Set text color for placeholder
                passwordTextBox.UseSystemPasswordChar = false; // Unmask for placeholder
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            // Validate input
            if (firstName == "First name" || string.IsNullOrWhiteSpace(firstName) ||
                lastName == "Last name" || string.IsNullOrWhiteSpace(lastName) ||
                email == "Email" || string.IsNullOrWhiteSpace(email) ||
                password == "Password" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulate saving the user data
            MessageBox.Show("Sign-up successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate back to the login form
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
            this.Close();
        }
    }
}
