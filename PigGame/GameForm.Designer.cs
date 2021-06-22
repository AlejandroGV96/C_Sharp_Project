
namespace PigGame
{
    partial class GameForm
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
            this.pPlayerOne = new System.Windows.Forms.Panel();
            this.lRoundScorePlayerOne = new System.Windows.Forms.Label();
            this.lRoundScoreTxtOne = new System.Windows.Forms.Label();
            this.lScorePlayerOne = new System.Windows.Forms.Label();
            this.lPlayerOne = new System.Windows.Forms.Label();
            this.pPlayerTwo = new System.Windows.Forms.Panel();
            this.lRoundScorePlayerTwo = new System.Windows.Forms.Label();
            this.lRoundScoreTxtTwo = new System.Windows.Forms.Label();
            this.lScorePlayerTwo = new System.Windows.Forms.Label();
            this.lPlayerTwo = new System.Windows.Forms.Label();
            this.bHold = new System.Windows.Forms.Button();
            this.bRollDice = new System.Windows.Forms.Button();
            this.bNewGame = new System.Windows.Forms.Button();
            this.pPlayerOne.SuspendLayout();
            this.pPlayerTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPlayerOne
            // 
            this.pPlayerOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pPlayerOne.Controls.Add(this.lRoundScorePlayerOne);
            this.pPlayerOne.Controls.Add(this.lRoundScoreTxtOne);
            this.pPlayerOne.Controls.Add(this.lScorePlayerOne);
            this.pPlayerOne.Controls.Add(this.lPlayerOne);
            this.pPlayerOne.Location = new System.Drawing.Point(17, 16);
            this.pPlayerOne.Margin = new System.Windows.Forms.Padding(4);
            this.pPlayerOne.Name = "pPlayerOne";
            this.pPlayerOne.Size = new System.Drawing.Size(357, 523);
            this.pPlayerOne.TabIndex = 0;
            // 
            // lRoundScorePlayerOne
            // 
            this.lRoundScorePlayerOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRoundScorePlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoundScorePlayerOne.Location = new System.Drawing.Point(4, 410);
            this.lRoundScorePlayerOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRoundScorePlayerOne.Name = "lRoundScorePlayerOne";
            this.lRoundScorePlayerOne.Size = new System.Drawing.Size(349, 29);
            this.lRoundScorePlayerOne.TabIndex = 3;
            this.lRoundScorePlayerOne.Text = "0";
            this.lRoundScorePlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lRoundScoreTxtOne
            // 
            this.lRoundScoreTxtOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRoundScoreTxtOne.Location = new System.Drawing.Point(4, 340);
            this.lRoundScoreTxtOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRoundScoreTxtOne.Name = "lRoundScoreTxtOne";
            this.lRoundScoreTxtOne.Size = new System.Drawing.Size(349, 17);
            this.lRoundScoreTxtOne.TabIndex = 2;
            this.lRoundScoreTxtOne.Text = "Round Score";
            this.lRoundScoreTxtOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lScorePlayerOne
            // 
            this.lScorePlayerOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lScorePlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScorePlayerOne.ForeColor = System.Drawing.Color.Firebrick;
            this.lScorePlayerOne.Location = new System.Drawing.Point(4, 134);
            this.lScorePlayerOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lScorePlayerOne.Name = "lScorePlayerOne";
            this.lScorePlayerOne.Size = new System.Drawing.Size(349, 95);
            this.lScorePlayerOne.TabIndex = 1;
            this.lScorePlayerOne.Text = "0";
            this.lScorePlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lPlayerOne
            // 
            this.lPlayerOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerOne.Location = new System.Drawing.Point(4, 41);
            this.lPlayerOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlayerOne.Name = "lPlayerOne";
            this.lPlayerOne.Size = new System.Drawing.Size(349, 36);
            this.lPlayerOne.TabIndex = 0;
            this.lPlayerOne.Text = "Player One";
            this.lPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPlayerTwo
            // 
            this.pPlayerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPlayerTwo.Controls.Add(this.lRoundScorePlayerTwo);
            this.pPlayerTwo.Controls.Add(this.lRoundScoreTxtTwo);
            this.pPlayerTwo.Controls.Add(this.lScorePlayerTwo);
            this.pPlayerTwo.Controls.Add(this.lPlayerTwo);
            this.pPlayerTwo.Location = new System.Drawing.Point(693, 16);
            this.pPlayerTwo.Margin = new System.Windows.Forms.Padding(4);
            this.pPlayerTwo.Name = "pPlayerTwo";
            this.pPlayerTwo.Size = new System.Drawing.Size(357, 523);
            this.pPlayerTwo.TabIndex = 1;
            // 
            // lRoundScorePlayerTwo
            // 
            this.lRoundScorePlayerTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRoundScorePlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoundScorePlayerTwo.Location = new System.Drawing.Point(4, 409);
            this.lRoundScorePlayerTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRoundScorePlayerTwo.Name = "lRoundScorePlayerTwo";
            this.lRoundScorePlayerTwo.Size = new System.Drawing.Size(349, 29);
            this.lRoundScorePlayerTwo.TabIndex = 3;
            this.lRoundScorePlayerTwo.Text = "0";
            this.lRoundScorePlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lRoundScoreTxtTwo
            // 
            this.lRoundScoreTxtTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRoundScoreTxtTwo.Location = new System.Drawing.Point(4, 340);
            this.lRoundScoreTxtTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRoundScoreTxtTwo.Name = "lRoundScoreTxtTwo";
            this.lRoundScoreTxtTwo.Size = new System.Drawing.Size(349, 17);
            this.lRoundScoreTxtTwo.TabIndex = 2;
            this.lRoundScoreTxtTwo.Text = "Round Score";
            this.lRoundScoreTxtTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lScorePlayerTwo
            // 
            this.lScorePlayerTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lScorePlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScorePlayerTwo.ForeColor = System.Drawing.Color.Firebrick;
            this.lScorePlayerTwo.Location = new System.Drawing.Point(4, 134);
            this.lScorePlayerTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lScorePlayerTwo.Name = "lScorePlayerTwo";
            this.lScorePlayerTwo.Size = new System.Drawing.Size(343, 95);
            this.lScorePlayerTwo.TabIndex = 1;
            this.lScorePlayerTwo.Text = "0";
            this.lScorePlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lPlayerTwo
            // 
            this.lPlayerTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerTwo.Location = new System.Drawing.Point(4, 41);
            this.lPlayerTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPlayerTwo.Name = "lPlayerTwo";
            this.lPlayerTwo.Size = new System.Drawing.Size(349, 36);
            this.lPlayerTwo.TabIndex = 0;
            this.lPlayerTwo.Text = "Player Two";
            this.lPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bHold
            // 
            this.bHold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bHold.Location = new System.Drawing.Point(483, 470);
            this.bHold.Margin = new System.Windows.Forms.Padding(4);
            this.bHold.Name = "bHold";
            this.bHold.Size = new System.Drawing.Size(100, 28);
            this.bHold.TabIndex = 2;
            this.bHold.Text = "Hold";
            this.bHold.UseVisualStyleBackColor = true;
            this.bHold.Click += new System.EventHandler(this.bHold_Click);
            // 
            // bRollDice
            // 
            this.bRollDice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bRollDice.Location = new System.Drawing.Point(483, 385);
            this.bRollDice.Margin = new System.Windows.Forms.Padding(4);
            this.bRollDice.Name = "bRollDice";
            this.bRollDice.Size = new System.Drawing.Size(100, 28);
            this.bRollDice.TabIndex = 3;
            this.bRollDice.Text = "Roll Dice!";
            this.bRollDice.UseVisualStyleBackColor = true;
            this.bRollDice.Click += new System.EventHandler(this.bRollDice_Click);
            // 
            // bNewGame
            // 
            this.bNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bNewGame.Location = new System.Drawing.Point(483, 16);
            this.bNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.bNewGame.Name = "bNewGame";
            this.bNewGame.Size = new System.Drawing.Size(100, 28);
            this.bNewGame.TabIndex = 4;
            this.bNewGame.Text = "New Game";
            this.bNewGame.UseVisualStyleBackColor = true;
            this.bNewGame.Click += new System.EventHandler(this.bNewGame_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bNewGame);
            this.Controls.Add(this.bRollDice);
            this.Controls.Add(this.bHold);
            this.Controls.Add(this.pPlayerTwo);
            this.Controls.Add(this.pPlayerOne);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "The Pig Game!";
            this.pPlayerOne.ResumeLayout(false);
            this.pPlayerTwo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPlayerOne;
        private System.Windows.Forms.Label lRoundScoreTxtOne;
        private System.Windows.Forms.Label lPlayerOne;
        private System.Windows.Forms.Panel pPlayerTwo;
        private System.Windows.Forms.Label lRoundScoreTxtTwo;
        private System.Windows.Forms.Label lPlayerTwo;
        public System.Windows.Forms.Label lRoundScorePlayerOne;
        public System.Windows.Forms.Label lRoundScorePlayerTwo;
        public System.Windows.Forms.Label lScorePlayerOne;
        public System.Windows.Forms.Label lScorePlayerTwo;
        public System.Windows.Forms.Button bHold;
        public System.Windows.Forms.Button bRollDice;
        public System.Windows.Forms.Button bNewGame;
    }
}

