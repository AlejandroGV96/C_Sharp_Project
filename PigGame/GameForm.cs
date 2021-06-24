using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
GAME RULES:
- The game has 2 players, playing in rounds
- In each turn, a player rolls the dices as many times as he whishes. Each result get added to his ROUND score
- BUT, if the player rolls two 1, all his ROUND score gets lost. After that, it's the next player's turn
- IF the rolled dice were 6 twice in a row, the player LOSES all his acumulated GLOBAL score and it's the next player's turn
- The player can choose to 'Hold', which means that his ROUND score gets added to his GLOBAL score. After that, it's the next player's turn
- The first player to reach the Limit Score points on GLOBAL score wins the game
*/
namespace PigGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            GameState.Init(this);
        }

        private void bHold_Click(object sender, EventArgs e)
        {
            GameState.ActivePlayer.Hold();
        }

        private void bRollDice_Click(object sender, EventArgs e)
        {
            GameState.ActivePlayer.RollDice();
        }

        private void bNewGame_Click(object sender, EventArgs e)
        {
            GameState.NewGame(this);
        }

        private void bRules_Click(object sender, EventArgs e)
        {
            string message = ("The game has 2 players, playing in rounds:\n\n\n   - In each turn, a player rolls the dices as many times as he whishes. Each result get added to his ROUND score.\n\n   - BUT, if the player rolls two 1, all his ROUND score gets lost. After that, it's the next player's turn.\n\n   - IF the rolled dice were 6 twice in a row, the player LOSES all his acumulated GLOBAL score and it's the next player's turn.\n\n   - The player can choose to 'Hold', which means that his ROUND score gets added to his GLOBAL score. After that, it's the next player's turn.\n\n   - The first player to reach the 100 points on GLOBAL score wins the game.");
            string title = "The Pig Game rules";
            MessageBox.Show(message, title);
        }
    }

    public class Player
    {
        private static uint _prevDice1 = 0;
        private static uint _prevDice2 = 0;
        
        private static uint _dice1 = 0;
        private static uint _dice2 = 0;

        public uint DieOne => _dice1;
        public uint DieTwo => _dice2;

        private uint _Score;
        static private uint _RoundScore;

        public uint Score => _Score;
        public uint RoundScore => _RoundScore;

        public Player()
        {
            _Score = 0;
            _RoundScore = 0;
        }

        private void EndTurn()
        {
            // Set _RoundScore and prevDice to zero
            _RoundScore = 0;
            _prevDice1 = 0;
            _prevDice2 = 0;

            // Update Round Score to zero
            GameState.UpdateRoundScore();

            // Change Player turn
            GameState.ChangeTurn();
            
        }

        public void RollDice()
        {

            // Roll two dice
            Random r = new Random();
            _dice1 = (uint)r.Next(1,7);
            _dice2 = (uint)r.Next(1, 7);
            GameState.UpdateDie();
            // Check conditions
                //Update the round score iff the rolled numbers were not both x1
                bool conditionOne = !(_dice1 == 1 && _dice2 == 1);
                //Update the round score iff there were not two sixes rolled in a row
                bool conditionTwo = !(_prevDice1 + _dice1 == 12 || _prevDice1 + _dice2 == 12 || _prevDice2 + _dice1 == 12 || _prevDice2 + _dice2 == 12);

            // Add to _RoundScore if conditions met
            if(conditionOne && conditionTwo)
            {
                _RoundScore += (_dice1 + _dice2);
                GameState.UpdateRoundScore();
                _prevDice1 = _dice1;
                _prevDice2 = _dice2;

            }
            // Call EndTurn() if conditions are not met
            else
            {
                string Message;
                if (!conditionOne) Message = "Oops, you rolled two ones!\r\n";
                else
                {
                    _Score = 0;
                    GameState.UpdateScore();
                    Message = "Too risky! You rolled two times six in a row.\r\n";
                }
                GameState.UpdateEventBox(Message);
                EndTurn();
            }

        }
        public void Hold()
        {
            // Add _RoundScore to _Score
            _Score +=_RoundScore;
            string Message;
            if (RoundScore == 0)
            {
                Message = "You... passed?\r\n";
            }else
            {
                Message = $"You added {RoundScore} points to your score!\r\n";
            }
            GameState.UpdateEventBox(Message);
            GameState.UpdateScore();

            // Evaluate if win to set GameState.ThereIsWinner to true and call GameState.EndGame() or
            if (_Score >= GameState.WinningScore)
            {
                GameState.ThereIsWinner = true;
                GameState.EndGame();
            }
            // Call EndTurn()
            else EndTurn();
        }
    }

    static public class GameState
    {
        public static GameForm _gameForm;
        public static uint WinningScore;
        public static Player ActivePlayer;
        public static Player[] Players;
        public static bool ThereIsWinner;
        
        public static void Init(GameForm gameForm)
        {
            Players = new Player[]
            {
                new Player(),
                new Player()
            };
            _gameForm = gameForm;
            _gameForm.bHold.Enabled = true;
            _gameForm.bRollDice.Enabled = true;
            WinningScore = 100;
            ThereIsWinner = false;
            ActivePlayer = Players[0];
            _gameForm.pPlayerOne.BackColor = System.Drawing.Color.White;
            _gameForm.pPlayerTwo.BackColor = System.Drawing.Color.FromArgb(150, 255, 255, 255);
        }

        public static void UpdateScore()
        {
            // Update Round Score on Player Roll and player Endturn
            Label TurnPlayerScore;
            // Decide to whom update the score
            if (ActivePlayer == Players[0]) TurnPlayerScore = _gameForm.lScorePlayerOne;
            else TurnPlayerScore = _gameForm.lScorePlayerTwo;
            // Update Score on Hold
            TurnPlayerScore.Text = ActivePlayer.Score.ToString();
        }

        public static void UpdateRoundScore()
        {
            Label TurnPlayerRoundScore;
            // Decide to whom update the round score
            if (ActivePlayer == Players[0]) TurnPlayerRoundScore = _gameForm.lRoundScorePlayerOne;
            else TurnPlayerRoundScore = _gameForm.lRoundScorePlayerTwo;
            // Update Round Score on Roll
            TurnPlayerRoundScore.Text = ActivePlayer.RoundScore.ToString();

        }
        public static void UpdateEventBox(string Message)
        {
            TextBox TurnPlayerEventBox;
            // Decide to whom update the event panel
            if (ActivePlayer == Players[0]) TurnPlayerEventBox = _gameForm.tbPlayerOne;
            else TurnPlayerEventBox = _gameForm.tbPlayerTwo;
            // Update the event panel
            TurnPlayerEventBox.AppendText(Message);
        }

        public static void UpdateDie()
        {
            // Update Dice GUI image depending on rolled dice
            switch (ActivePlayer.DieOne)
            {
                case 1: _gameForm.DieOne.Image = Properties.Resources.dice_1; break;
                case 2: _gameForm.DieOne.Image = Properties.Resources.dice_2; break;
                case 3: _gameForm.DieOne.Image = Properties.Resources.dice_3; break;
                case 4: _gameForm.DieOne.Image = Properties.Resources.dice_4; break;
                case 5: _gameForm.DieOne.Image = Properties.Resources.dice_5; break;
                case 6: _gameForm.DieOne.Image = Properties.Resources.dice_6; break;
            }
            switch (ActivePlayer.DieTwo)
            {
                case 1: _gameForm.DieTwo.Image = Properties.Resources.dice_1; break;
                case 2: _gameForm.DieTwo.Image = Properties.Resources.dice_2; break;
                case 3: _gameForm.DieTwo.Image = Properties.Resources.dice_3; break;
                case 4: _gameForm.DieTwo.Image = Properties.Resources.dice_4; break;
                case 5: _gameForm.DieTwo.Image = Properties.Resources.dice_5; break;
                case 6: _gameForm.DieTwo.Image = Properties.Resources.dice_6; break;
            }
        }

        private static void UpdateUI()
        {

            // Evaluate if there is a winner to for updating UI accordingly
            if (ThereIsWinner)
            {
                if (ActivePlayer == Players[0])
                {
                    _gameForm.lPlayerOne.Text = "WINNER!";
                    _gameForm.lPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    _gameForm.lPlayerOne.ForeColor = System.Drawing.Color.Firebrick;

                }
                else
                {
                    _gameForm.lPlayerTwo.Text = "WINNER!";
                    _gameForm.lPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    _gameForm.lPlayerTwo.ForeColor = System.Drawing.Color.Firebrick;
                }
            }
            else
            {
                // Highlight ActivePlayer Panel and grey up non active
                //for each player, check if active and execute if else to higlight or greyup PlayerUI panel
                if (ActivePlayer == Players[1])
                {
                    _gameForm.pPlayerOne.BackColor = System.Drawing.Color.White;
                    _gameForm.pPlayerTwo.BackColor = System.Drawing.Color.FromArgb(150, 255, 255, 255);
                }
                else
                {
                    _gameForm.pPlayerTwo.BackColor = System.Drawing.Color.White;
                    _gameForm.pPlayerOne.BackColor = System.Drawing.Color.FromArgb(150, 255, 255, 255);
                }
            }
        }

        public static void ChangeTurn()
        {
            UpdateUI();
            
            // Change ActivePlayer
            if (ActivePlayer == Players[0]) ActivePlayer = Players[1];
            else ActivePlayer = Players[0];

        }

        public static void EndGame()
        {
            // Disable both players' buttons
            _gameForm.bHold.Enabled = false;
            _gameForm.bRollDice.Enabled = false;

            // Call UpdateUI()
            UpdateUI();
        }

        public static void NewGame(GameForm gameForm)
        {
            // Set all GUI scores to initial state
            _gameForm.lRoundScorePlayerOne.Text = "0";
            _gameForm.lRoundScorePlayerTwo.Text = "0";
            _gameForm.lScorePlayerOne     .Text = "0";
            _gameForm.lScorePlayerTwo     .Text = "0";

            // Remove dice images from GUI
            _gameForm.DieOne.Image = null;
            _gameForm.DieTwo.Image = null;
            
            // Clear Players' GUI event boxes
            _gameForm.tbPlayerOne.Text = "";
            _gameForm.tbPlayerTwo.Text = "";

            // Reset Players' GUI panels to initial state
            _gameForm.lPlayerOne.Text = "Player One";
            _gameForm.lPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _gameForm.lPlayerOne.ForeColor = System.Drawing.Color.Black;

            _gameForm.lPlayerTwo.Text = "Player Two";
            _gameForm.lPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _gameForm.lPlayerTwo.ForeColor = System.Drawing.Color.Black;
            
            // Initialize all scores to zero
            Init(gameForm);
        }
    }



}
