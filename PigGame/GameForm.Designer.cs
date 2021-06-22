
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
            this.pPlayerOne.SuspendLayout();
            this.pPlayerTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPlayerOne
            // 
            this.pPlayerOne.Controls.Add(this.lRoundScorePlayerOne);
            this.pPlayerOne.Controls.Add(this.lRoundScoreTxtOne);
            this.pPlayerOne.Controls.Add(this.lScorePlayerOne);
            this.pPlayerOne.Controls.Add(this.lPlayerOne);
            this.pPlayerOne.Location = new System.Drawing.Point(13, 13);
            this.pPlayerOne.Name = "pPlayerOne";
            this.pPlayerOne.Size = new System.Drawing.Size(268, 425);
            this.pPlayerOne.TabIndex = 0;
            // 
            // lRoundScorePlayerOne
            // 
            this.lRoundScorePlayerOne.AutoSize = true;
            this.lRoundScorePlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoundScorePlayerOne.Location = new System.Drawing.Point(125, 333);
            this.lRoundScorePlayerOne.Name = "lRoundScorePlayerOne";
            this.lRoundScorePlayerOne.Size = new System.Drawing.Size(20, 24);
            this.lRoundScorePlayerOne.TabIndex = 3;
            this.lRoundScorePlayerOne.Text = "0";
            // 
            // lRoundScoreTxtOne
            // 
            this.lRoundScoreTxtOne.AutoSize = true;
            this.lRoundScoreTxtOne.Location = new System.Drawing.Point(100, 276);
            this.lRoundScoreTxtOne.Name = "lRoundScoreTxtOne";
            this.lRoundScoreTxtOne.Size = new System.Drawing.Size(70, 13);
            this.lRoundScoreTxtOne.TabIndex = 2;
            this.lRoundScoreTxtOne.Text = "Round Score";
            // 
            // lScorePlayerOne
            // 
            this.lScorePlayerOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lScorePlayerOne.AutoSize = true;
            this.lScorePlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScorePlayerOne.ForeColor = System.Drawing.Color.Firebrick;
            this.lScorePlayerOne.Location = new System.Drawing.Point(100, 109);
            this.lScorePlayerOne.Name = "lScorePlayerOne";
            this.lScorePlayerOne.Size = new System.Drawing.Size(70, 76);
            this.lScorePlayerOne.TabIndex = 1;
            this.lScorePlayerOne.Text = "0";
            // 
            // lPlayerOne
            // 
            this.lPlayerOne.AutoSize = true;
            this.lPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerOne.Location = new System.Drawing.Point(69, 33);
            this.lPlayerOne.Name = "lPlayerOne";
            this.lPlayerOne.Size = new System.Drawing.Size(133, 29);
            this.lPlayerOne.TabIndex = 0;
            this.lPlayerOne.Text = "Player One";
            // 
            // pPlayerTwo
            // 
            this.pPlayerTwo.Controls.Add(this.lRoundScorePlayerTwo);
            this.pPlayerTwo.Controls.Add(this.lRoundScoreTxtTwo);
            this.pPlayerTwo.Controls.Add(this.lScorePlayerTwo);
            this.pPlayerTwo.Controls.Add(this.lPlayerTwo);
            this.pPlayerTwo.Location = new System.Drawing.Point(520, 13);
            this.pPlayerTwo.Name = "pPlayerTwo";
            this.pPlayerTwo.Size = new System.Drawing.Size(268, 425);
            this.pPlayerTwo.TabIndex = 1;
            // 
            // lRoundScorePlayerTwo
            // 
            this.lRoundScorePlayerTwo.AutoSize = true;
            this.lRoundScorePlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoundScorePlayerTwo.Location = new System.Drawing.Point(128, 332);
            this.lRoundScorePlayerTwo.Name = "lRoundScorePlayerTwo";
            this.lRoundScorePlayerTwo.Size = new System.Drawing.Size(20, 24);
            this.lRoundScorePlayerTwo.TabIndex = 3;
            this.lRoundScorePlayerTwo.Text = "0";
            // 
            // lRoundScoreTxtTwo
            // 
            this.lRoundScoreTxtTwo.AutoSize = true;
            this.lRoundScoreTxtTwo.Location = new System.Drawing.Point(102, 276);
            this.lRoundScoreTxtTwo.Name = "lRoundScoreTxtTwo";
            this.lRoundScoreTxtTwo.Size = new System.Drawing.Size(70, 13);
            this.lRoundScoreTxtTwo.TabIndex = 2;
            this.lRoundScoreTxtTwo.Text = "Round Score";
            // 
            // lScorePlayerTwo
            // 
            this.lScorePlayerTwo.AutoSize = true;
            this.lScorePlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScorePlayerTwo.ForeColor = System.Drawing.Color.Firebrick;
            this.lScorePlayerTwo.Location = new System.Drawing.Point(102, 109);
            this.lScorePlayerTwo.Name = "lScorePlayerTwo";
            this.lScorePlayerTwo.Size = new System.Drawing.Size(70, 76);
            this.lScorePlayerTwo.TabIndex = 1;
            this.lScorePlayerTwo.Text = "0";
            // 
            // lPlayerTwo
            // 
            this.lPlayerTwo.AutoSize = true;
            this.lPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerTwo.Location = new System.Drawing.Point(68, 33);
            this.lPlayerTwo.Name = "lPlayerTwo";
            this.lPlayerTwo.Size = new System.Drawing.Size(135, 29);
            this.lPlayerTwo.TabIndex = 0;
            this.lPlayerTwo.Text = "Player Two";
            // 
            // bHold
            // 
            this.bHold.Location = new System.Drawing.Point(362, 383);
            this.bHold.Name = "bHold";
            this.bHold.Size = new System.Drawing.Size(75, 23);
            this.bHold.TabIndex = 2;
            this.bHold.Text = "Hold";
            this.bHold.UseVisualStyleBackColor = true;
            this.bHold.Click += new System.EventHandler(this.bHold_Click);
            // 
            // bRollDice
            // 
            this.bRollDice.Location = new System.Drawing.Point(362, 313);
            this.bRollDice.Name = "bRollDice";
            this.bRollDice.Size = new System.Drawing.Size(75, 23);
            this.bRollDice.TabIndex = 3;
            this.bRollDice.Text = "Roll Dice!";
            this.bRollDice.UseVisualStyleBackColor = true;
            this.bRollDice.Click += new System.EventHandler(this.bRollDice_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRollDice);
            this.Controls.Add(this.bHold);
            this.Controls.Add(this.pPlayerTwo);
            this.Controls.Add(this.pPlayerOne);
            this.Name = "GameForm";
            this.Text = "The Pig Game!";
            this.pPlayerOne.ResumeLayout(false);
            this.pPlayerOne.PerformLayout();
            this.pPlayerTwo.ResumeLayout(false);
            this.pPlayerTwo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPlayerOne;
        private System.Windows.Forms.Label lRoundScoreTxtOne;
        private System.Windows.Forms.Label lPlayerOne;
        private System.Windows.Forms.Panel pPlayerTwo;
        private System.Windows.Forms.Label lRoundScoreTxtTwo;
        private System.Windows.Forms.Label lPlayerTwo;
        private System.Windows.Forms.Button bHold;
        private System.Windows.Forms.Button bRollDice;
        public System.Windows.Forms.Label lRoundScorePlayerOne;
        public System.Windows.Forms.Label lRoundScorePlayerTwo;
        public System.Windows.Forms.Label lScorePlayerOne;
        public System.Windows.Forms.Label lScorePlayerTwo;
    }
}

