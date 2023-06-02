namespace StarWarsFinal
{
    partial class Player1Form
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
            this.allPlayer1Box = new System.Windows.Forms.ListBox();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.player1txtBox = new System.Windows.Forms.TextBox();
            this.playerLbl = new System.Windows.Forms.Label();
            this.player1Box = new System.Windows.Forms.ListBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.player1NameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allPlayer1Box
            // 
            this.allPlayer1Box.FormattingEnabled = true;
            this.allPlayer1Box.ItemHeight = 20;
            this.allPlayer1Box.Items.AddRange(new object[] {
            "Luke Skywalker = 1",
            "C-3PO = 2",
            "R2-D2 = 3",
            "Darth Vader = 4",
            "Leia Organa = 5",
            "Owen Lars = 6",
            "Beru Whitesun lars = 7",
            "R5-D4 = 8",
            "Biggs Darklighter = 9",
            "Obi-Wan Kenobi = 10"});
            this.allPlayer1Box.Location = new System.Drawing.Point(47, 59);
            this.allPlayer1Box.Name = "allPlayer1Box";
            this.allPlayer1Box.Size = new System.Drawing.Size(264, 224);
            this.allPlayer1Box.TabIndex = 0;
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(43, 15);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(245, 20);
            this.instructionLbl.TabIndex = 1;
            this.instructionLbl.Text = "These are all the players available";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(594, 59);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(112, 41);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // player1txtBox
            // 
            this.player1txtBox.Location = new System.Drawing.Point(418, 66);
            this.player1txtBox.Name = "player1txtBox";
            this.player1txtBox.Size = new System.Drawing.Size(145, 26);
            this.player1txtBox.TabIndex = 3;
            this.player1txtBox.TextChanged += new System.EventHandler(this.player1txtBox_TextChanged);
            // 
            // playerLbl
            // 
            this.playerLbl.AutoSize = true;
            this.playerLbl.Location = new System.Drawing.Point(417, 15);
            this.playerLbl.Name = "playerLbl";
            this.playerLbl.Size = new System.Drawing.Size(323, 20);
            this.playerLbl.TabIndex = 4;
            this.playerLbl.Text = "Type an id you\'re interested in learning about";
            // 
            // player1Box
            // 
            this.player1Box.FormattingEnabled = true;
            this.player1Box.ItemHeight = 20;
            this.player1Box.Location = new System.Drawing.Point(417, 155);
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(157, 204);
            this.player1Box.TabIndex = 5;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(329, 386);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(107, 37);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // player1NameLbl
            // 
            this.player1NameLbl.AutoSize = true;
            this.player1NameLbl.Location = new System.Drawing.Point(421, 113);
            this.player1NameLbl.Name = "player1NameLbl";
            this.player1NameLbl.Size = new System.Drawing.Size(109, 20);
            this.player1NameLbl.TabIndex = 7;
            this.player1NameLbl.Text = "Player 1 name";
            // 
            // Player1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player1NameLbl);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.playerLbl);
            this.Controls.Add(this.player1txtBox);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.allPlayer1Box);
            this.Name = "Player1Form";
            this.Text = "Player1Form";
            this.Load += new System.EventHandler(this.Player1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allPlayer1Box;
        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.TextBox player1txtBox;
        private System.Windows.Forms.Label playerLbl;
        private System.Windows.Forms.ListBox player1Box;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label player1NameLbl;
    }
}