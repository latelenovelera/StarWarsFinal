using StarWarsFinal.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsFinal
{
    //Inherits from Form
    public partial class Player2Form : Form
    {
        //Player2Form attributes
        Players pl1 = new Players();
        Players currentPlayer = new Players();
         
        //pl1 which is first player will be used to compare first and second
        //player name and runs the form.
        public Player2Form(Players player1)
        {
            pl1 = player1;
            InitializeComponent();
        }

        //Takes player 2 input which should be an id  between the numbers 1 to 10 and is not the same 
        //as player 1
        //then displays the player's mass, height, and gender. Player 2 will be renamed as current player.
        //If player 2 input is a name the message 'Please enter a player id' will occur.
        //Or if the id is higher than 10 the message 'Please enter a valid id. A number between 1 to 10'
        //will print.
        private async void selectPlayer2Btn_Click(object sender, EventArgs e)
        {
            Players player2 = await JsonHelper.GetPlayers(player2txtBox.Text);

            if (string.IsNullOrEmpty(player2txtBox.Text))
            {
                MessageBox.Show("Please enter a player id");
            }
            else
            {
                //is this correct format (it seems to be working fine, though)
                if (player2.name != null && player2.name != pl1.name && Convert.ToInt32(player2txtBox.Text) <= 10)
                {
                    player2Box.Items.Clear();
                    player2Box.Items.Add("Player mass: " + player2.mass);
                    player2Box.Items.Add("Player height: " + player2.height);
                    player2Box.Items.Add("Player gender: " + player2.gender);
                    player2NameLbl.Text = player2.name;
                    currentPlayer = player2;
                }
                else
                {
                    currentPlayer = new Players();
                    MessageBox.Show("Please enter a different id. A number between 1 to 10");
                }
            }

          
        }

        //Ensures that second player (currenPlayer) is not empty, not the same id as the first player,
        //and is between the number one to ten.
        //If the player id is good then BattleForm will appear.
        //Otherwise, the message 'Invalid selection' will occur.
        private void next2Btn_Click(object sender, EventArgs e)
        {
            //the same comment from above applies here
            if (currentPlayer.name != null && pl1.name != currentPlayer.name && Convert.ToInt32(player2txtBox.Text) <= 10)
            {
                this.Hide();
                BattleForm battleForm = new BattleForm(pl1, currentPlayer);
                battleForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid selection");
            }
        }


        

        private void Player2Form_Load(object sender, EventArgs e)
        {

        }

    }

}
