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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text.Trim();
            string confirmPassword = confirmPasswordTextBox.Text.Trim();

            // Ensure fields are not empty or set to placeholder values
            if (newPassword == "New password" || confirmPassword == "Confirm new password" ||
                string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Both fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulate successful password reset
            MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate back to login form or close the current form
            this.Close();
            LoginPage loginForm = Application.OpenForms["Form1"] as LoginPage;
            if (loginForm != null)
            {
                loginForm.Show();
            }
        }

        private void newPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text == "New password")
            {
                newPasswordTextBox.Text = "";
                newPasswordTextBox.ForeColor = Color.Black;
                newPasswordTextBox.UseSystemPasswordChar = true; // Mask input
            }
        }

        private void newPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
            {
                newPasswordTextBox.Text = "New password";
                newPasswordTextBox.ForeColor = Color.Gray;
                newPasswordTextBox.UseSystemPasswordChar = false; // Unmask input for placeholder
            }
        }

        private void confirmPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text == "Confirm new password")
            {
                confirmPasswordTextBox.Text = "";
                confirmPasswordTextBox.ForeColor = Color.Black;
                confirmPasswordTextBox.UseSystemPasswordChar = true; // Mask input
            }
        }

        private void confirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                confirmPasswordTextBox.Text = "Confirm new password";
                confirmPasswordTextBox.ForeColor = Color.Gray;
                confirmPasswordTextBox.UseSystemPasswordChar = false; // Unmask input for placeholder
            }
        }
    }
}
