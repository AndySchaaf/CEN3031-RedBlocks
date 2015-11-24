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
    public partial class VideoGameScreen : Form
    {
        private VideoGame selectedGame;
        private User workingUser;
        private string sql;
        private RentalManagementSystem managementSystem = new RentalManagementSystem();
        private bool rentable;
        public VideoGameScreen(VideoGame selectedGame, User workingUser, bool rentable)
        {
            InitializeComponent();
            this.rentable = rentable;
            this.selectedGame = selectedGame;
            this.workingUser = workingUser;
            this.Text = selectedGame.getTitle();
            titleLabel.Text = selectedGame.getTitle();
            genreLabel.Text = selectedGame.getGenre();
            consoleLabel.Text = selectedGame.getConsole();
            inventoryLabel.Text = selectedGame.getInventory().ToString();

            if (rentable)
            {
                returnButton.Enabled = false;
            }
            else
            {
                rentButton.Enabled = false;
            }
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            sql = "UPDATE Video_Games SET inventory = (inventory - 1) WHERE id = " 
                + selectedGame.getID() 
                + ";";

            if (!managementSystem.excecuteData(sql))
            {
                MessageBox.Show("Error renting movie");
            }
            else
            {
                sql = "INSERT INTO Users_Games VALUES ("
                + workingUser.getProfile().getUserID()
                + "," + selectedGame.getID()
                + ");";

                if (!managementSystem.excecuteData(sql))
                {
                    MessageBox.Show("Error renting movie");
                }
                else
                {
                    MessageBox.Show("Success!");
                    this.Hide();
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            sql = "update Video_Games set inventory = (inventory + 1) where id = "
                + selectedGame.getID()
                + ";";

            if (!managementSystem.excecuteData(sql))
            {
                MessageBox.Show("Error returning movie");
            }
            else
            {
                sql = "delete from Users_Games where userID = '"
                    + workingUser.getProfile().getUserID()
                    + "' and gameID = '"
                    + selectedGame.getID()
                    + "';";

                if (!managementSystem.excecuteData(sql))
                {
                    MessageBox.Show("Error returning movie");
                }
                else
                {
                    MessageBox.Show("Success!");
                    this.Hide();
                }
            }
        }

        private void VideoGameScreen_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void genreLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void consoleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
