
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
            this.tbPlayerOne = new System.Windows.Forms.TextBox();
            this.lRoundScorePlayerOne = new System.Windows.Forms.Label();
            this.lRoundScoreTxtOne = new System.Windows.Forms.Label();
            this.lScorePlayerOne = new System.Windows.Forms.Label();
            this.lPlayerOne = new System.Windows.Forms.Label();
            this.pPlayerTwo = new System.Windows.Forms.Panel();
            this.tbPlayerTwo = new System.Windows.Forms.TextBox();
            this.lRoundScorePlayerTwo = new System.Windows.Forms.Label();
            this.lRoundScoreTxtTwo = new System.Windows.Forms.Label();
            this.lScorePlayerTwo = new System.Windows.Forms.Label();
            this.lPlayerTwo = new System.Windows.Forms.Label();
            this.bHold = new System.Windows.Forms.Button();
            this.bRollDice = new System.Windows.Forms.Button();
            this.bNewGame = new System.Windows.Forms.Button();
            this.DieOne = new System.Windows.Forms.PictureBox();
            this.DieTwo = new System.Windows.Forms.PictureBox();
            this.pPlayerOne.SuspendLayout();
            this.pPlayerTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DieOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // pPlayerOne
            // 
            this.pPlayerOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pPlayerOne.BackColor = System.Drawing.Color.White;
            this.pPlayerOne.Controls.Add(this.tbPlayerOne);
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
            // tbPlayerOne
            // 
            this.tbPlayerOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayerOne.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPlayerOne.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbPlayerOne.Location = new System.Drawing.Point(19, 429);
            this.tbPlayerOne.Multiline = true;
            this.tbPlayerOne.Name = "tbPlayerOne";
            this.tbPlayerOne.ReadOnly = true;
            this.tbPlayerOne.ShortcutsEnabled = false;
            this.tbPlayerOne.Size = new System.Drawing.Size(319, 70);
            this.tbPlayerOne.TabIndex = 4;
            this.tbPlayerOne.TabStop = false;
            this.tbPlayerOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lRoundScorePlayerOne
            // 
            this.lRoundScorePlayerOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRoundScorePlayerOne.BackColor = System.Drawing.Color.Transparent;
            this.lRoundScorePlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoundScorePlayerOne.Location = new System.Drawing.Point(4, 376);
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
            this.lRoundScoreTxtOne.BackColor = System.Drawing.Color.Transparent;
            this.lRoundScoreTxtOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoundScoreTxtOne.Location = new System.Drawing.Point(4, 340);
            this.lRoundScoreTxtOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRoundScoreTxtOne.Name = "lRoundScoreTxtOne";
            this.lRoundScoreTxtOne.Size = new System.Drawing.Size(349, 29);
            this.lRoundScoreTxtOne.TabIndex = 2;
            this.lRoundScoreTxtOne.Text = "Round Score";
            this.lRoundScoreTxtOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lScorePlayerOne
            // 
            this.lScorePlayerOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lScorePlayerOne.BackColor = System.Drawing.Color.Transparent;
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
            this.lPlayerOne.BackColor = System.Drawing.Color.Transparent;
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
            this.pPlayerTwo.BackColor = System.Drawing.Color.White;
            this.pPlayerTwo.Controls.Add(this.tbPlayerTwo);
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
            // tbPlayerTwo
            // 
            this.tbPlayerTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlayerTwo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPlayerTwo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbPlayerTwo.Location = new System.Drawing.Point(19, 429);
            this.tbPlayerTwo.Multiline = true;
            this.tbPlayerTwo.Name = "tbPlayerTwo";
            this.tbPlayerTwo.ReadOnly = true;
            this.tbPlayerTwo.ShortcutsEnabled = false;
            this.tbPlayerTwo.Size = new System.Drawing.Size(319, 70);
            this.tbPlayerTwo.TabIndex = 5;
            this.tbPlayerTwo.TabStop = false;
            this.tbPlayerTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lRoundScorePlayerTwo
            // 
            this.lRoundScorePlayerTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRoundScorePlayerTwo.BackColor = System.Drawing.Color.Transparent;
            this.lRoundScorePlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoundScorePlayerTwo.Location = new System.Drawing.Point(4, 376);
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
            this.lRoundScoreTxtTwo.BackColor = System.Drawing.Color.Transparent;
            this.lRoundScoreTxtTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoundScoreTxtTwo.Location = new System.Drawing.Point(4, 340);
            this.lRoundScoreTxtTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRoundScoreTxtTwo.Name = "lRoundScoreTxtTwo";
            this.lRoundScoreTxtTwo.Size = new System.Drawing.Size(349, 29);
            this.lRoundScoreTxtTwo.TabIndex = 2;
            this.lRoundScoreTxtTwo.Text = "Round Score";
            this.lRoundScoreTxtTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lScorePlayerTwo
            // 
            this.lScorePlayerTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lScorePlayerTwo.BackColor = System.Drawing.Color.Transparent;
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
            this.lPlayerTwo.BackColor = System.Drawing.Color.Transparent;
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
            this.bHold.BackColor = System.Drawing.Color.White;
            this.bHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHold.Location = new System.Drawing.Point(469, 476);
            this.bHold.Margin = new System.Windows.Forms.Padding(4);
            this.bHold.Name = "bHold";
            this.bHold.Size = new System.Drawing.Size(129, 63);
            this.bHold.TabIndex = 2;
            this.bHold.Text = "Hold";
            this.bHold.UseVisualStyleBackColor = false;
            this.bHold.Click += new System.EventHandler(this.bHold_Click);
            // 
            // bRollDice
            // 
            this.bRollDice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bRollDice.BackColor = System.Drawing.Color.White;
            this.bRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRollDice.Location = new System.Drawing.Point(469, 392);
            this.bRollDice.Margin = new System.Windows.Forms.Padding(4);
            this.bRollDice.Name = "bRollDice";
            this.bRollDice.Size = new System.Drawing.Size(129, 63);
            this.bRollDice.TabIndex = 3;
            this.bRollDice.Text = "Roll Dice!";
            this.bRollDice.UseVisualStyleBackColor = false;
            this.bRollDice.Click += new System.EventHandler(this.bRollDice_Click);
            // 
            // bNewGame
            // 
            this.bNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bNewGame.BackColor = System.Drawing.Color.White;
            this.bNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewGame.Location = new System.Drawing.Point(469, 16);
            this.bNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.bNewGame.Name = "bNewGame";
            this.bNewGame.Size = new System.Drawing.Size(129, 63);
            this.bNewGame.TabIndex = 4;
            this.bNewGame.Text = "New Game";
            this.bNewGame.UseVisualStyleBackColor = false;
            this.bNewGame.Click += new System.EventHandler(this.bNewGame_Click);
            // 
            // DieOne
            // 
            this.DieOne.BackColor = System.Drawing.Color.Transparent;
            this.DieOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DieOne.Location = new System.Drawing.Point(432, 199);
            this.DieOne.Name = "DieOne";
            this.DieOne.Size = new System.Drawing.Size(71, 71);
            this.DieOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DieOne.TabIndex = 5;
            this.DieOne.TabStop = false;
            // 
            // DieTwo
            // 
            this.DieTwo.BackColor = System.Drawing.Color.Transparent;
            this.DieTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DieTwo.Location = new System.Drawing.Point(564, 199);
            this.DieTwo.Name = "DieTwo";
            this.DieTwo.Size = new System.Drawing.Size(71, 71);
            this.DieTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DieTwo.TabIndex = 6;
            this.DieTwo.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PigGame.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DieTwo);
            this.Controls.Add(this.DieOne);
            this.Controls.Add(this.bNewGame);
            this.Controls.Add(this.bRollDice);
            this.Controls.Add(this.bHold);
            this.Controls.Add(this.pPlayerTwo);
            this.Controls.Add(this.pPlayerOne);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "The Pig Game!";
            this.pPlayerOne.ResumeLayout(false);
            this.pPlayerOne.PerformLayout();
            this.pPlayerTwo.ResumeLayout(false);
            this.pPlayerTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DieOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DieTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lRoundScoreTxtOne;
        private System.Windows.Forms.Label lRoundScoreTxtTwo;
        public System.Windows.Forms.Label lRoundScorePlayerOne;
        public System.Windows.Forms.Label lRoundScorePlayerTwo;
        public System.Windows.Forms.Label lScorePlayerOne;
        public System.Windows.Forms.Label lScorePlayerTwo;
        public System.Windows.Forms.Button bHold;
        public System.Windows.Forms.Button bRollDice;
        public System.Windows.Forms.Button bNewGame;
        public System.Windows.Forms.Panel pPlayerOne;
        public System.Windows.Forms.Panel pPlayerTwo;
        public System.Windows.Forms.TextBox tbPlayerOne;
        public System.Windows.Forms.TextBox tbPlayerTwo;
        public System.Windows.Forms.PictureBox DieOne;
        public System.Windows.Forms.PictureBox DieTwo;
        public System.Windows.Forms.Label lPlayerOne;
        public System.Windows.Forms.Label lPlayerTwo;
    }
}

