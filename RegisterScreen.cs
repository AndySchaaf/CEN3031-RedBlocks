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
    public partial class RegisterScreen : Form
    {
        private User user;
        private RentalMainScreen rentalScreen;
        private RentalManagementSystem managementSystem = new RentalManagementSystem();
        private Dictionary<TextBox, string> boxes = new Dictionary<TextBox, string>();
        private const string EMPTY_STRING = "";
        public RegisterScreen()
        {
            InitializeComponent();
            initializeDict();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (checkValidTextBoxes())
            {
                if (managementSystem.register(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text,
                   passwordTextBox.Text, addressTextBox.Text, cityTextBox.Text, stateComboBox.Text, zipTextBox.Text))
                {
                    User loggedInUser = managementSystem.logIn(emailTextBox.Text, passwordTextBox.Text);
                    if (loggedInUser != null)
                    {
                        rentalScreen = new RentalMainScreen(loggedInUser);
                        rentalScreen.Show();
                        this.Hide();
                    }
                }
            }
        }

        private bool checkValidTextBoxes()
        {
            if (passwordTextBox.Text != passwordConfirmTextBox.Text)
            {
                MessageBox.Show("Password fields did not match");
                return false;
            }
            foreach (var boxTextPair in boxes)
            {
                TextBox box = boxTextPair.Key;
                string presetText = boxTextPair.Value;

                if (box.Text.Equals(EMPTY_STRING) ||
                    box.Text.Equals(presetText))
                {
                    MessageBox.Show(presetText + " box invalid.");
                    return false;
                }
            }
            return true;
        }

        private void initializeDict()
        {
            boxes.Add(firstNameTextBox, "First name");
            boxes.Add(lastNameTextBox, "Last name");
            boxes.Add(emailTextBox, "E-mail address");
            boxes.Add(passwordTextBox, "Password");
            boxes.Add(passwordConfirmTextBox, "Confirm password");
            boxes.Add(addressTextBox, "Street address");
            boxes.Add(cityTextBox, "City");
            boxes.Add(zipTextBox, "Zip");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen logInScreen = new LogInScreen();
            logInScreen.Show();
            this.Hide();
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Equals("Password"))
            {
                passwordTextBox.Text = EMPTY_STRING;
            }
            passwordTextBox.PasswordChar = '*';
        }

        private void passwordConfirmTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordConfirmTextBox.Text.Equals("Confirm password"))
            {
                passwordConfirmTextBox.Text  = EMPTY_STRING;
            }
            passwordConfirmTextBox.PasswordChar = '*';
        }

        private void passwordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void passwordConfirmTextBox_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
