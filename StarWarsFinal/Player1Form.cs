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
    public partial class Player1Form : Form
    {
        //Player1Form attribute
        Players currentPlayer = new Players();

        //Runs the Player1Form
        public Player1Form()
        {
            InitializeComponent();
        }

        private void Player1Form_Load(object sender, EventArgs e)
        {
                       
        }

        //Takes player 1 input which should be an id  between the numbers 1 to 10 
        //and displays the player's mass, height, and gender. Player 1 will be renamed as current player.
        //If player 1 input is a name the message 'Please enter a player id' will occur.
        //Or if the id is higher than 10 the message 'Please enter a valid id. A number between 1 to 10'
        //will print.
        private async void selectBtn_Click(object sender, EventArgs e)
        {
            Players player1 = await JsonHelper.GetPlayers(player1txtBox.Text);

            if (string.IsNullOrEmpty(player1txtBox.Text))
            {
                MessageBox.Show("Please enter a player id");
            }
            else
            {
                //is this correct format (it seems to be working fine, though)
                if (player1.name != null && Convert.ToInt32(player1txtBox.Text) <= 10)
                {
                    player1Box.Items.Clear();
                    player1Box.Items.Add("Player mass: " + player1.mass);
                    player1Box.Items.Add("Player height: "+ player1.height);
                    player1Box.Items.Add("Player gender: "  + player1.gender);
                    player1NameLbl.Text = player1.name;
                    currentPlayer = player1;
                }
                else
                {
                    currentPlayer = new Players();
                    MessageBox.Show("Please enter a valid id. A number between 1 to 10");
                }
            }


           
        }

        //Ensures that first player (currenPlayer) is not empty and that the player's id is between the number
        //one to ten.
        //If the player id is good then Player2Form will appear.
        //Otherwise, the message 'Invalid selection' will occur.
        private void nextBtn_Click(object sender, EventArgs e)
        {
            //the same comment from above applies here
            if (currentPlayer.name != null && Convert.ToInt32(player1txtBox.Text) <= 10)
            {
                this.Hide();

                Player2Form p2Form = new Player2Form(currentPlayer);
                p2Form.Show();
            }
            else
            {
                MessageBox.Show("Invalid selection");
            }
        }


        private void player1txtBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
