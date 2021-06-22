using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }

    public class Player
    {
        private static uint _prevDice1 = 0;
        private static uint _prevDice2 = 0;
        private static uint _dice1 = 0;
        private static uint _dice2 = 0;

        private uint _ID;
        private uint _Score;
        static private uint _RoundScore;

        public uint ID => _ID;
        public uint Score => _Score;
        public uint RoundScore => _RoundScore;

        public Player(uint id)
        {
            _ID = id;
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
                EndTurn();
            }

        }
        public void Hold()
        {
            // Add _RoundScore to _Score
            //GameState._gameForm.lScorePlayerOne.Text = (GameState.ActivePlayer.Score + GameState.ActivePlayer.RoundScore).ToString();
            _Score +=_RoundScore;
            GameState.UpdateScore();
            //_RoundScore = 0;
            //GameState.UpdateRoundScore();
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
                new Player(0),
                new Player(1)
            };
            _gameForm = gameForm;
            _gameForm.bHold.Enabled = true;
            _gameForm.bRollDice.Enabled = true;
            WinningScore = 100;
            ThereIsWinner = false;
            ActivePlayer = Players[0];
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

        private static void UpdateUI()
        {

            // Evaluate if there is a winner to for updating UI accordingly, otherwise...
            if (ThereIsWinner)
            {
                // Set winner UI for ActivePlayer
            }
            else
            {
             // Highlight ActivePlayer Panel and grey up non active
                //for each player, check if active and execute if else to higlight or greyup PlayerUI panel

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
            // Initialize all scores to zero
            _gameForm.lRoundScorePlayerOne.Text = "0";
            _gameForm.lRoundScorePlayerTwo.Text = "0";
            _gameForm.lScorePlayerOne     .Text = "0";
            _gameForm.lScorePlayerTwo     .Text = "0";
            Init(gameForm);
        }
    }



}
