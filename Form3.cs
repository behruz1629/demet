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
    public partial class ConfirmCodeForm : Form
    {
        public ConfirmCodeForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string enteredCode = codeTextBox.Text.Trim(); // Replace with your TextBox name
            string actualCode = "123456"; // Example expected code

            if (enteredCode == actualCode)
            {
                MessageBox.Show("Code confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the Reset Password Form
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
                resetPasswordForm.Show();

                // Hide the current form (optional)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmCodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginPage form1 = Application.OpenForms["Form1"] as LoginPage;
            if (form1 != null)
            {
                form1.Show();
            }
        }
    }
}
