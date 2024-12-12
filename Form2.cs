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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;

            // Validate email input
            if (string.IsNullOrWhiteSpace(email) || email == "Account/email")
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Simulate sending a confirmation email (you can implement real logic later)
                MessageBox.Show($"Confirmation email sent to {email}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the ConfirmCodeForm
                ConfirmCodeForm confirmCodeForm = new ConfirmCodeForm();
                confirmCodeForm.Show();
                this.Hide(); // Hide the first form if necessary
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if(emailTextBox.Text == "Enter your email")
    {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Text = "Enter your email";
                emailTextBox.ForeColor = Color.Gray;
            }
        }

        private void ForgotPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the first form (Form1)
            LoginPage form1 = Application.OpenForms["Form1"] as LoginPage;
            if (form1 != null)
            {
                form1.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
