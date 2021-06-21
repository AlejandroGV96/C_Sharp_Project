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
        }
    }

    public class Player
    {
        private uint _ID;
        private uint _Score;
        private uint _RoundScore;
        public bool _IsActive;

        public Player(uint id)
        {
            _ID = id;
            _Score = 0;
            _RoundScore = 0;
            _IsActive = false;
        }

        private void EndTurn()
        {
            // Set _RoundScore to zero

            // Call GameState.UpdateUI()

            // Switch GameState.ActivePlayer and call GameState.ChangeTurn()
        }

        public void RollDice()
        {
            // Roll two dice

            // Check conditions

            // Add to _RoundScore if conditions met
            // Call EndTurn() if conditions are not met
        }
        public void Hold()
        {
            // Add _RoundScore to _Score

            // Evaluate if win to set GameState.ThereIsWinner to true and call GameState.EndGame() or
            // Call EndTurn()
        }
    }

    static public class GameState
    {
        public static Player ActivePlayer;
        public static Player[] Players;
        public static bool ThereIsWinner;
        
        public static void Init()
        {
            Players = new Player[]
            {
                new Player(0),
                new Player(1)
            };
            ThereIsWinner = false;
            ActivePlayer = Players[0];
            Players[0]._IsActive = true;
            UpdateUI();
        }

        private static void UpdateUI()
        {
            // Evaluate if there is a winner to for updating UI accordingly, otherwise...

            // Evaluate which player is active
            
            // Highlight ActivePlayer Panel and grey up non active
        }

        public static void ChangeTurn()
        {
            // Disable not Active Player buttons and Activate ActivePlayer Buttons

            // Call UpdateUI()
        }

        private static void EndGame()
        {
            // Disable both players' buttons

            // Call UpdateUI()
        }

        public static void NewGame()
        {
            // Initialize all scores to zero
            // ActivePlayer to 1, ThereIsWinner to false

        }

        public static void ButtonRoll()
        {
            // Evaluate which player is active

            // Call ActivePlayer.RollDice()
        }

        public static void ButtonHold()
        {
            // Evaluate which player is active

            // Call ActivePlayer.Hold()
        }
    }



}
