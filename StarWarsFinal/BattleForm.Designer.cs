namespace StarWarsFinal
{
    partial class BattleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player1StanceLbl = new System.Windows.Forms.Label();
            this.player2StanceLbl = new System.Windows.Forms.Label();
            this.vsLbl = new System.Windows.Forms.Label();
            this.winnerLbl = new System.Windows.Forms.Label();
            this.finalWinnerLbl = new System.Windows.Forms.Label();
            this.battleInstructionLbl = new System.Windows.Forms.Label();
            this.battleBox = new System.Windows.Forms.ListBox();
            this.newBattleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1StanceLbl
            // 
            this.player1StanceLbl.AutoSize = true;
            this.player1StanceLbl.Location = new System.Drawing.Point(78, 21);
            this.player1StanceLbl.Name = "player1StanceLbl";
            this.player1StanceLbl.Size = new System.Drawing.Size(61, 20);
            this.player1StanceLbl.TabIndex = 0;
            this.player1StanceLbl.Text = "Player1";
            // 
            // player2StanceLbl
            // 
            this.player2StanceLbl.AutoSize = true;
            this.player2StanceLbl.Location = new System.Drawing.Point(327, 21);
            this.player2StanceLbl.Name = "player2StanceLbl";
            this.player2StanceLbl.Size = new System.Drawing.Size(61, 20);
            this.player2StanceLbl.TabIndex = 1;
            this.player2StanceLbl.Text = "Player2";
            // 
            // vsLbl
            // 
            this.vsLbl.AutoSize = true;
            this.vsLbl.Location = new System.Drawing.Point(232, 21);
            this.vsLbl.Name = "vsLbl";
            this.vsLbl.Size = new System.Drawing.Size(31, 20);
            this.vsLbl.TabIndex = 2;
            this.vsLbl.Text = "VS";
            // 
            // winnerLbl
            // 
            this.winnerLbl.AutoSize = true;
            this.winnerLbl.Location = new System.Drawing.Point(165, 107);
            this.winnerLbl.Name = "winnerLbl";
            this.winnerLbl.Size = new System.Drawing.Size(52, 20);
            this.winnerLbl.TabIndex = 3;
            this.winnerLbl.Text = "Player";
            // 
            // finalWinnerLbl
            // 
            this.finalWinnerLbl.AutoSize = true;
            this.finalWinnerLbl.Location = new System.Drawing.Point(263, 107);
            this.finalWinnerLbl.Name = "finalWinnerLbl";
            this.finalWinnerLbl.Size = new System.Drawing.Size(46, 20);
            this.finalWinnerLbl.TabIndex = 5;
            this.finalWinnerLbl.Text = "Won!";
            // 
            // battleInstructionLbl
            // 
            this.battleInstructionLbl.AutoSize = true;
            this.battleInstructionLbl.Location = new System.Drawing.Point(101, 262);
            this.battleInstructionLbl.Name = "battleInstructionLbl";
            this.battleInstructionLbl.Size = new System.Drawing.Size(81, 20);
            this.battleInstructionLbl.TabIndex = 6;
            this.battleInstructionLbl.Text = "Battle info";
            // 
            // battleBox
            // 
            this.battleBox.FormattingEnabled = true;
            this.battleBox.ItemHeight = 20;
            this.battleBox.Items.AddRange(new object[] {
            "Player 1 weight vs Player 2 weight ",
            "Player 1 height vs Player 2 height "});
            this.battleBox.Location = new System.Drawing.Point(34, 301);
            this.battleBox.Name = "battleBox";
            this.battleBox.Size = new System.Drawing.Size(275, 144);
            this.battleBox.TabIndex = 7;
            // 
            // newBattleBtn
            // 
            this.newBattleBtn.Location = new System.Drawing.Point(404, 321);
            this.newBattleBtn.Name = "newBattleBtn";
            this.newBattleBtn.Size = new System.Drawing.Size(114, 36);
            this.newBattleBtn.TabIndex = 9;
            this.newBattleBtn.Text = "New battle";
            this.newBattleBtn.UseVisualStyleBackColor = true;
            this.newBattleBtn.Click += new System.EventHandler(this.newBattleBtn_Click);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 555);
            this.Controls.Add(this.newBattleBtn);
            this.Controls.Add(this.battleBox);
            this.Controls.Add(this.battleInstructionLbl);
            this.Controls.Add(this.finalWinnerLbl);
            this.Controls.Add(this.winnerLbl);
            this.Controls.Add(this.vsLbl);
            this.Controls.Add(this.player2StanceLbl);
            this.Controls.Add(this.player1StanceLbl);
            this.Name = "BattleForm";
            this.Text = "BattleForm";
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1StanceLbl;
        private System.Windows.Forms.Label player2StanceLbl;
        private System.Windows.Forms.Label vsLbl;
        private System.Windows.Forms.Label winnerLbl;
        private System.Windows.Forms.Label finalWinnerLbl;
        private System.Windows.Forms.Label battleInstructionLbl;
        private System.Windows.Forms.ListBox battleBox;
        private System.Windows.Forms.Button newBattleBtn;
    }
}