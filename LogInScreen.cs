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
        
        //This is the first screen users see when opening up the application
        public LogInScreen()
        {
            //Visual studio generated method
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            //Log in method called using management system
            User loggedInUser = managementSystem.logIn(EmailTextBox.Text, PasswordTextBox.Text);
            //If login is successful
            if (loggedInUser != null)
            {
                //Create a new main screen and pass the user as a parameter
                rentalScreen = new RentalMainScreen(loggedInUser);
                rentalScreen.Show();
                this.Hide();
            }
            else // Login failed
            {
                MessageBox.Show("Invalid login. Please Try again.");
            }
        }
        //"Register" label
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //If clicked create new register screen
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.Show();
            this.Hide();
        }

        //Dont delete-----
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
