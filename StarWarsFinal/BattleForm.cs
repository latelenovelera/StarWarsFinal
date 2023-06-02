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
    public partial class BattleForm : Form
    {
        //BattleForm attributes
        Players pl1 = new Players();
        Players pl2 = new Players();

        //BattleForm constructors that takes in pl1 (player one) and pl2 (player two).
        public BattleForm(Players player1, Players player2)
        {
            InitializeComponent();
            pl1 = player1;
            pl2 = player2;
        }

        //From Round1 takes the first and second player to compare mass
        //whichever player is the heaviest win
        //From Round2 takes the first and second player to compare height
        //whichever player is the tallest win
        //In Compete takes into account the win(s) of the players individually
        //From Round whichever player (one or two) has the most wins, wins
        //and displays the winner
        private async void BattleForm_Load(object sender, EventArgs e)
        {
            Round1 win1 = new Round1(pl1, pl2);
            Round2 win2 = new Round2(pl1, pl2);
            Players victor1 = win1.Compete();
            Players victor2 = win2.Compete();
            Round roundFinal = new Round(victor1, victor2);
            Players winner = roundFinal.Winner();
            player1StanceLbl.Text = pl1.name;
            player2StanceLbl.Text = pl2.name;
            winnerLbl.Text = winner.name;

        }

        //Brings you back to the first screen
        private void newBattleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Player1Form backToForm = new Player1Form();
            backToForm.Show();
        }
    }
}
