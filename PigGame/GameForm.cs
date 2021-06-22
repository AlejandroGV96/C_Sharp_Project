﻿using System;
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
            GameState.Init();
        }
    }

    public class Player
    {
        private static uint _prevDice1 = 0;
        private static uint _prevDice2 = 0;

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
            // Set _RoundScore and prevDice to zero
            _RoundScore = 0;
            _prevDice1 = 0;
            _prevDice2 = 0;
            _IsActive = false;

            // Switch GameState.ActivePlayer and call GameState.ChangeTurn()
            if (GameState.ActivePlayer == GameState.Players[0]) GameState.ActivePlayer = GameState.Players[1];
            else GameState.ActivePlayer = GameState.Players[0];

            GameState.ActivePlayer._IsActive = true;
            GameState.ChangeTurn();
        }

        public void RollDice()
        {
            // Roll two dice
            Random r = new Random();
            uint dice1 = (uint)r.Next(1,7);
            uint dice2 = (uint)r.Next(1, 7);

            // Check conditions
                //Update the round score iff the rolled numbers were not both x1
                bool conditionOne = !(dice1 != 1 && dice2 != 1);
                //Update the round score iff there were not two sixes rolled in a row
                bool conditionTwo = !(_prevDice1 + dice1 == 12 || _prevDice1 + dice2 == 12 || _prevDice2 + dice1 == 12 || _prevDice2 + dice2 == 12);

            // Add to _RoundScore if conditions met
            if(conditionOne && conditionTwo)
            {
                _RoundScore += (dice1 + dice2);
                _prevDice1 = dice1;
                _prevDice2 = dice2;

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
            _Score +=_RoundScore;
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
        public static uint WinningScore;
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
            WinningScore = 100;
            ThereIsWinner = false;
            ActivePlayer = Players[0];
            Players[0]._IsActive = true;
            ChangeTurn();
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
                foreach (var player in Players)
                {
                    if (player._IsActive)
                    {
                        // Activate UI
                    }
                    else
                    {
                        // Deactivate UI
                    }
                }
            }
        }

        public static void ChangeTurn()
        {

         // Disable not Active Player buttons and Activate ActivePlayer Buttons
            //for each player, check if active and execute if else to disable or enable buttons
            foreach (var player in Players)
            {
                if (player._IsActive)
                {
                    // Activate controls
                }
                else
                {
                    // Deactivate controls
                }
            }

            // Call UpdateUI()
            UpdateUI();
        }

        public static void EndGame()
        {
            // Disable both players' buttons
            foreach (var player in Players)
            {
                // Disable controls
            }

            // Call UpdateUI()
            UpdateUI();
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
            ActivePlayer.RollDice();
        }

        public static void ButtonHold()
        {
            // Evaluate which player is active
            // Call ActivePlayer.Hold()
            ActivePlayer.Hold();
        }
    }



}
