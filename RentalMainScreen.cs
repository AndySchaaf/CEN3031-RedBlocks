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
    public partial class RentalMainScreen : Form
    {
        private User workingUser;
        private RentalManagementSystem managementSystem = new RentalManagementSystem();
        private DataTable dt;
        private string sql;
        private string searchSql;

        public RentalMainScreen(User workingUser)
        {
            InitializeComponent(); 
            
            if (workingUser != null) 
            {
                this.workingUser = workingUser;
                userNameLabel.Text = workingUser.getProfile().getFirstName() + "!";
            }

        }

        private void SignOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen logInScreen = new LogInScreen();
            logInScreen.Show();
            this.Hide();
        }

        private void RentalMainScreen_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM Video_Games WHERE inventory > 0";
            dt = managementSystem.fillDataTable(sql);
            dataGridView1.DataSource = dt;

            List<string> consoles = new List<string>();
            consoles.Add("All");
            List<string> genres = new List<string>();
            genres.Add("All");

            foreach (DataRow row in dt.Rows)
            {
                if (!consoles.Contains(row[2].ToString()))
                {
                    consoles.Add(row[2].ToString());
                }

                if (!genres.Contains(row[3].ToString()))
                {
                    genres.Add(row[3].ToString());
                }
            }

            string[] consoleArray = consoles.ToArray();
            string[] genreArray = genres.ToArray();

            consoleComboBox.Items.AddRange(consoleArray);
            genreComboBox.Items.AddRange(genreArray);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountScreen accountScreen = new AccountScreen(workingUser);
            accountScreen.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (genreComboBox.Text.Equals("Genre") || genreComboBox.Text.Equals("All"))
            {
                if (consoleComboBox.Text.Equals("All"))
                {
                    sql = "SELECT * FROM Video_Games WHERE inventory > 0";
                }
                else
                {
                    sql = "SELECT * FROM Video_Games WHERE inventory > 0 AND console = '" 
                        + consoleComboBox.Text + "';";
                }
            }
            else
            {
                if (consoleComboBox.Text.Equals("All"))
                {
                    sql = "SELECT * FROM Video_Games WHERE inventory > 0 AND genre = '" 
                        + genreComboBox.Text + "';";
                }
                else
                {
                    sql = "SELECT * FROM Video_Games WHERE inventory > 0 AND console = '" 
                        + consoleComboBox.Text + "'" 
                        + "AND genre = '" + genreComboBox.Text + "';";
                }
            }
            dt = managementSystem.fillDataTable(sql);
            dataGridView1.DataSource = dt;
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Text = "";

            if (consoleComboBox.Text.Equals("Console") || consoleComboBox.Text.Equals("All"))
            {
                if (genreComboBox.Text.Equals("All"))
                {
                    sql = "SELECT * FROM Video_Games WHERE inventory > 0";
                }
                else
                {
                    sql = "SELECT * FROM Video_Games WHERE inventory > 0 AND genre = '"
                        + genreComboBox.Text + "';";
                }
            }
            else
            {
                if (genreComboBox.Text.Equals("All"))
                {
                    sql = "SELECT * FROM Video_Games WHERE inventory > 0 AND console = '"
                        + consoleComboBox.Text + "';";
                }
                else
                {
                    sql = "SELECT * FROM Video_Games WHERE inventory > 0 AND console = '"
                        + consoleComboBox.Text + "'"
                        + "AND genre = '" + genreComboBox.Text + "';";
                }
            }
            dt = managementSystem.fillDataTable(sql);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            int clickedRow = e.RowIndex;
            foreach (DataRow row in dt.Rows)
            {
                if (index == clickedRow)
                {
                    VideoGame selectedGame = new VideoGame(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), int.Parse(row[4].ToString()));
                    VideoGameScreen gameScreen = new VideoGameScreen(selectedGame, workingUser, true);
                    gameScreen.Show();
                }
                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchSql = "SELECT * FROM Video_Games WHERE title LIKE '%" + searchBox.Text + "%';";
            dt = managementSystem.fillDataTable(searchSql);
            dataGridView1.DataSource = dt;
        }

        private void RentalMainScreen_Activated(object sender, EventArgs e)
        {
            dt = managementSystem.fillDataTable(sql);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
