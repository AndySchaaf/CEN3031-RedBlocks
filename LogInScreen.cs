using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameRentalSystem
{
    public partial class LogInScreen : Form
    {
        private RentalMainScreen rentalScreen;
        private RentalManagementSystem managementSystem = new RentalManagementSystem();

        public LogInScreen()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            User loggedInUser = managementSystem.logIn(EmailTextBox.Text, PasswordTextBox.Text);
            if (loggedInUser != null)
            {
                rentalScreen = new RentalMainScreen(loggedInUser);
                rentalScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login. Please Try again.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.Show();
            this.Hide();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
