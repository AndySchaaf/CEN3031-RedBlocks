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
    public partial class EditProfileScreen : Form
    {
        private string sql;
        private DataTable dt;
        private RentalManagementSystem managementSystem = new RentalManagementSystem();
        private User workingUser;

        public EditProfileScreen(User workingUser)
        {
            InitializeComponent();
            this.workingUser = workingUser;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            sql = "UPDATE Users " +
                   "SET first_name = '"+ firstNameTextBox.Text + "', " +
                    "last_name = '"+ lastNameTextBox.Text + "', " +
                    "email = '"+ emailTextBox.Text + "', " + 
                    "street = '"+ addressTextBox.Text + "', " +
                    "city = '"+ cityTextBox.Text + "', " +
                    "st = '"+ stateComboBox.Text + "', " +
                    "zip = '"+ zipTextBox.Text + "' " +
                    "WHERE id = " + workingUser.getProfile().getUserID() + ";";

            if(!managementSystem.excecuteData(sql)) {
                MessageBox.Show("Error updating profile");
            }
            else
            {
                workingUser.setProfile(workingUser.getProfile().getUserID(),
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    emailTextBox.Text,
                    workingUser.getProfile().getPassword(),
                    addressTextBox.Text,
                    cityTextBox.Text,
                    stateComboBox.Text,
                    zipTextBox.Text);

                MessageBox.Show("Success!");
                this.Close();
            }
        }

        private void EditProfileScreen_Activated(object sender, EventArgs e)
        {
            firstNameTextBox.Text = workingUser.getProfile().getFirstName();
            lastNameTextBox.Text = workingUser.getProfile().getLastName();
            emailTextBox.Text = workingUser.getProfile().getEmail();
            addressTextBox.Text = workingUser.getProfile().getAddress();
            cityTextBox.Text = workingUser.getProfile().getCity();
            stateComboBox.Text = workingUser.getProfile().getState();
            zipTextBox.Text = workingUser.getProfile().getZip();
        }

        private void EditProfileScreen_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
