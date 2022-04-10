using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayPlayers
{
    public partial class DisplayPlayers : Form
    {
        public DisplayPlayers()
        {
            InitializeComponent();
        }

        //create the connection to the Database information
        private Ostrander_Lab12_PlayersDB.BaseballEntities dbcontext = 
            new Ostrander_Lab12_PlayersDB.BaseballEntities();

        private void DisplayPlayers_Load(object sender, EventArgs e)
        {
            ErrorLabel.Text = ""; 

            //load players table ordered by PlayerID
            dbcontext.Players
                .OrderBy(player => player.PlayerID)
                .Load();
            //specify Datasource for playerbindingsource
            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void BrowseAll_Button_Click(object sender, EventArgs e)
        {
            playerBindingSource.DataSource =
                dbcontext.Players.Local
                .OrderBy(player => player.PlayerID);
        }

        private void Browse_Button_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";

            try
            {
                if (string.IsNullOrWhiteSpace(LastNameBox.Text))
                {
                    ErrorLabel.Text = "Error: Nothing was entered in the search box. Please enter a last name and try again.";
                }
                else
                {
                    Name = LastNameBox.Text;

                    playerBindingSource.DataSource =
                        dbcontext.Players.Local
                        .Where(player => player.LastName == Name)
                        .OrderBy(player => player.PlayerID);
                }

            }
            catch
            {
                ErrorLabel.Text = "Error: An unexpected error has occurred";
            }


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            decimal min = 0.0M;
            decimal max = 1M;

            try
            {
                if (string.IsNullOrWhiteSpace(minTextBox.Text) || string.IsNullOrWhiteSpace(maxTextBox.Text))
                {
                    min = 0.0M;
                    max = 1.0M;
                }
                else if (decimal.Parse(minTextBox.Text) < 0 || decimal.Parse(maxTextBox.Text) > 1 )
                {
                    ErrorLabel.Text = "Error: Values entered are not within range. Using defaults Min >= 0 and Max <= 1";
                }
                else
                {
                    min = decimal.Parse(minTextBox.Text);
                    max = decimal.Parse(maxTextBox.Text);
                }

                playerBindingSource.DataSource =
                    dbcontext.Players.Local
                    .Where(player => player.BattingAverage >= min && player.BattingAverage <= max)
                    .OrderBy(player => player.PlayerID);


            }catch
            {
                ErrorLabel.Text = "Error: An unexpected error has occurred";
            }

        }
    }
}
