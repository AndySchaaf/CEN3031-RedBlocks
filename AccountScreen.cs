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
    public partial class AccountScreen : Form
    {
        private string sql;
        private DataTable dt;
        private RentalManagementSystem managementSystem = new RentalManagementSystem();
        private User workingUser;

        //Working user is passed to thier account screen 
        public AccountScreen(User workingUser)
        {
            InitializeComponent();
            this.workingUser = workingUser;
        }

        //Called when user clicks on their "rented games" table
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            int clickedRow = e.RowIndex;
            foreach (DataRow outerRow in dt.Rows)
            {
                if (index == clickedRow)
                {
                    sql = "SELECT * FROM Video_Games WHERE title =  '"
                        + outerRow[0].ToString()
                        + "' AND console = '"
                        + outerRow[1].ToString()
                        + "';";
                    DataTable tempDT = managementSystem.fillDataTable(sql);
                    foreach (DataRow row in tempDT.Rows)
                    {
                        VideoGame selectedGame = new VideoGame(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), int.Parse(row[4].ToString()));
                        VideoGameScreen gameScreen = new VideoGameScreen(selectedGame, workingUser, false);
                        gameScreen.Show();
                    }
                }
                index++;
            }
        }

        private void AccountScreen_Activated(object sender, EventArgs e)
        {
            //Fills out the labels
            nameLabel.Text = workingUser.getProfile().getFirstName() + " " + workingUser.getProfile().getLastName();
            emailLabel.Text = workingUser.getProfile().getEmail();
            streetLabel.Text = workingUser.getProfile().getAddress();
            cityLabel.Text = workingUser.getProfile().getCity();
            stateLabel.Text = workingUser.getProfile().getState();
            zipLabel.Text = workingUser.getProfile().getZip();

            //This is sort of a complex SQL query but it joins the User with their rented games
            sql = "SELECT gameTitle AS 'Game Title',gameConsole AS 'Game Console' FROM ( ";
            sql += "SELECT Users.id AS userID,Video_Games.title AS gameTitle,Video_Games.console AS gameConsole ";
            sql += "FROM Users_Games ";
            sql += "inner join Video_Games ON Video_Games.id = Users_Games.gameID ";
            sql += "inner join Users ON Users.id = Users_Games.userID ";
            sql += ") allRentals ";
            sql += "WHERE allRentals.userID = " + workingUser.getProfile().getUserID();

            dt = managementSystem.fillDataTable(sql);
            dataGridView1.DataSource = dt;
        }
        //Edit profile button 
        private void button1_Click(object sender, EventArgs e)
        {
            EditProfileScreen editProfileScreen = new EditProfileScreen(workingUser);
            editProfileScreen.Show();
        }

        private void AccountScreen_MouseEnter(object sender, EventArgs e)
        {
        }

        private void AccountScreen_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
