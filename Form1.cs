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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Account/Email") // Placeholder text
            {
                emailTextBox.Text = ""; // Clear placeholder
                emailTextBox.ForeColor = Color.Black; // Change text color for user input
            }
        }
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text)) // Check if empty
            {
                emailTextBox.Text = "Account/Email"; // Restore placeholder text
                emailTextBox.ForeColor = Color.Gray; // Change text color for placeholder
            }
        }


        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void linkLabel1_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();

            // Show the second form
            forgotPasswordForm.Show();

            // Optional: Hide the first form (if desired)
            // this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text == "Password")
    {
                textBox2.Text = ""; // Clear placeholder text
                textBox2.ForeColor = Color.Black; // Set text color for user input
                textBox2.UseSystemPasswordChar = true; // Mask the input
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Password"; // Restore placeholder text
                textBox2.ForeColor = Color.Gray; // Set text color for placeholder
                textBox2.UseSystemPasswordChar = false; // Unmask for placeholder
            }
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            // Open the Sign-Up form
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();

            // Optionally hide the current form
            this.Hide();
        }

        
    }
}
