namespace StarWarsFinal
{
    partial class Player2Form
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
            this.player2NameLbl = new System.Windows.Forms.Label();
            this.next2Btn = new System.Windows.Forms.Button();
            this.player2Box = new System.Windows.Forms.ListBox();
            this.player2Lbl = new System.Windows.Forms.Label();
            this.player2txtBox = new System.Windows.Forms.TextBox();
            this.selectPlayer2Btn = new System.Windows.Forms.Button();
            this.secondInstructionLbl = new System.Windows.Forms.Label();
            this.allPlayer2Box = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // player2NameLbl
            // 
            this.player2NameLbl.AutoSize = true;
            this.player2NameLbl.Location = new System.Drawing.Point(420, 121);
            this.player2NameLbl.Name = "player2NameLbl";
            this.player2NameLbl.Size = new System.Drawing.Size(109, 20);
            this.player2NameLbl.TabIndex = 15;
            this.player2NameLbl.Text = "Player 2 name";
            // 
            // next2Btn
            // 
            this.next2Btn.Location = new System.Drawing.Point(327, 393);
            this.next2Btn.Name = "next2Btn";
            this.next2Btn.Size = new System.Drawing.Size(94, 34);
            this.next2Btn.TabIndex = 14;
            this.next2Btn.Text = "Next";
            this.next2Btn.UseVisualStyleBackColor = true;
            this.next2Btn.Click += new System.EventHandler(this.next2Btn_Click);
            // 
            // player2Box
            // 
            this.player2Box.FormattingEnabled = true;
            this.player2Box.ItemHeight = 20;
            this.player2Box.Location = new System.Drawing.Point(416, 163);
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(147, 204);
            this.player2Box.TabIndex = 13;
            // 
            // player2Lbl
            // 
            this.player2Lbl.AutoSize = true;
            this.player2Lbl.Location = new System.Drawing.Point(416, 23);
            this.player2Lbl.Name = "player2Lbl";
            this.player2Lbl.Size = new System.Drawing.Size(360, 20);
            this.player2Lbl.TabIndex = 12;
            this.player2Lbl.Text = "Type another id you\'re interested in learning about";
            // 
            // player2txtBox
            // 
            this.player2txtBox.Location = new System.Drawing.Point(416, 74);
            this.player2txtBox.Name = "player2txtBox";
            this.player2txtBox.Size = new System.Drawing.Size(135, 26);
            this.player2txtBox.TabIndex = 11;
            // 
            // selectPlayer2Btn
            // 
            this.selectPlayer2Btn.Location = new System.Drawing.Point(592, 67);
            this.selectPlayer2Btn.Name = "selectPlayer2Btn";
            this.selectPlayer2Btn.Size = new System.Drawing.Size(102, 41);
            this.selectPlayer2Btn.TabIndex = 10;
            this.selectPlayer2Btn.Text = "Select";
            this.selectPlayer2Btn.UseVisualStyleBackColor = true;
            this.selectPlayer2Btn.Click += new System.EventHandler(this.selectPlayer2Btn_Click);
            // 
            // secondInstructionLbl
            // 
            this.secondInstructionLbl.AutoSize = true;
            this.secondInstructionLbl.Location = new System.Drawing.Point(42, 23);
            this.secondInstructionLbl.Name = "secondInstructionLbl";
            this.secondInstructionLbl.Size = new System.Drawing.Size(79, 20);
            this.secondInstructionLbl.TabIndex = 9;
            this.secondInstructionLbl.Text = "Player\'s id";
            // 
            // allPlayer2Box
            // 
            this.allPlayer2Box.FormattingEnabled = true;
            this.allPlayer2Box.ItemHeight = 20;
            this.allPlayer2Box.Items.AddRange(new object[] {
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
            this.allPlayer2Box.Location = new System.Drawing.Point(46, 67);
            this.allPlayer2Box.Name = "allPlayer2Box";
            this.allPlayer2Box.Size = new System.Drawing.Size(254, 224);
            this.allPlayer2Box.TabIndex = 8;
            // 
            // Player2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player2NameLbl);
            this.Controls.Add(this.next2Btn);
            this.Controls.Add(this.player2Box);
            this.Controls.Add(this.player2Lbl);
            this.Controls.Add(this.player2txtBox);
            this.Controls.Add(this.selectPlayer2Btn);
            this.Controls.Add(this.secondInstructionLbl);
            this.Controls.Add(this.allPlayer2Box);
            this.Name = "Player2Form";
            this.Text = "Player2Form";
            this.Load += new System.EventHandler(this.Player2Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player2NameLbl;
        private System.Windows.Forms.Button next2Btn;
        private System.Windows.Forms.ListBox player2Box;
        private System.Windows.Forms.Label player2Lbl;
        private System.Windows.Forms.TextBox player2txtBox;
        private System.Windows.Forms.Button selectPlayer2Btn;
        private System.Windows.Forms.Label secondInstructionLbl;
        private System.Windows.Forms.ListBox allPlayer2Box;
    }
}