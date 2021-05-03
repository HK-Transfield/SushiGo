using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiGo
{
    /// <summary>
    /// The main GUI for the Sushi Go! card game.
    /// Each player contains two listboxes, one representing the player's
    /// hand, where cards are dealt into, and one representing the player's
    /// board where cards that are played are placed into.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region instance variables

        /// <summary>
        /// The deck where the player gets the cards from
        /// </summary>
        private Deck mainDeck = new Deck();

        /// <summary>
        /// The max number of cards in a players hand
        /// </summary>
        private const int MAX_CARDS = 10;

        /// <summary>
        /// Temporary hand needed when swapping hands at the
        /// end of each turn.
        /// </summary>
        private Hand handTemp = new Hand();

        /// <summary>
        /// The players of the game.
        /// There is also a computer player
        /// If playing a single player game.
        /// </summary>
        private Player player1 = null;
        private Player opponent = null;
        private Computer computerPlayer = null;

        /// <summary>
        /// Random number generator used to "shuffle" and deal
        /// cards from the deck.
        /// </summary>
        private Random shuffle = new Random();

        /// <summary>
        /// The round number of the game.
        /// </summary>
        private int numRound = 1;

        /// <summary>
        /// The total points each player scores.
        /// </summary>
        private int player1TotalPoints = 0;
        private int player2TotalPoints = 0;

        #endregion

        #region game-handling methods

        /// <summary>
        /// Deals 10 cards into each players hand.
        /// </summary>
        private void DealCards()
        {
            //Loads 10 cards into each player's hand
            for (int i = 1; i <= MAX_CARDS; i++)
            {
                //Deal 10 cards into player 1's hand and remove from deck
                int dealHand1 = shuffle.Next(0, mainDeck.DeckContents.Count - 1);
                player1.InitialiseHand(mainDeck.DeckContents[dealHand1]);
                mainDeck.DeckContents.RemoveAt(dealHand1);

                //Deal 10 cards into opponent's hand and remove from deck
                int dealHand2 = shuffle.Next(0, mainDeck.DeckContents.Count - 1);

                //If playing multiplayer game
                if (radioButtonMultiPlayer.Checked)
                    opponent.InitialiseHand(mainDeck.DeckContents[dealHand2]);

                //If player single player game
                else if (radioButtonSinglePlayer.Checked)
                    computerPlayer.InitialiseHand(mainDeck.DeckContents[dealHand2]);

                mainDeck.DeckContents.RemoveAt(dealHand2);
            }
        }

       /// <summary>
       /// Swaps the player's and the opponents hand.
       /// </summary>
       /// <param name="opponent">The player to swap the hand with</param>
        private void SwapHands(Player opponent)
        {
                //Swap players hands
                handTemp = player1.Hand;
                player1.Hand = null;
                player1.Hand = opponent.Hand;
                opponent.Hand = handTemp;

                //Update the player's hand
                player1.UpdateHand(listBoxPlayerOneHand);
                opponent.UpdateHand(listBoxPlayerTwoHand);
        }

        /// <summary>
        /// Ends the current round when both players
        /// have no more cards left to play.
        /// </summary>
        private void CheckRemainingCards(Player opponentPlayer)
        {
            //If no more players have cards left
            if (player1.Hand.CardsInHandList.Count == 0 || opponentPlayer.Hand.CardsInHandList.Count == 0)
            {
                //Enable / disable controls where appropriate
                buttonEndRound.Enabled = true;
                buttonPlayCardPlayerOne.Enabled = false;
                buttonPlayCardPlayerTwo.Enabled = false;
                listBoxFeedback.Items.Clear();
                listBoxFeedback.Items.Add("There are no more cards left to play!");
            }
        }

        /// <summary>
        /// Calculates the points the player gains based on the total
        /// number of cards that player has and compares it to their
        /// opponent. Used to compare Maki Roll cards and Pudding cards.
        /// </summary>
        /// <param name="player1TotalCards">The total number of cards the player has</param>
        /// <param name="opponentTotalCards">the total number of cards the opponent has</param>
        /// <param name="tiePoints">The number of points to give if tied</param>
        private void CalcComparisonPoints(int player1TotalCards, int opponentTotalCards, int tiePoints)
        {
            if (player1TotalCards > opponentTotalCards)
                player1TotalPoints += 6;

            else if (player1TotalCards < opponentTotalCards)
                player2TotalPoints += 6;

            else if (player1TotalCards == opponentTotalCards)
            {
                player2TotalPoints += tiePoints;
                player1TotalPoints += tiePoints;
            }
        }

        #endregion

        #region form controls event-handlers

        /// <summary>
        /// It loads the game, and
        /// it will have a welcome message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Initial feedback when loading the game
            listBoxFeedback.Items.Add("Welcome to Sushi Go!");
            listBoxFeedback.Items.Add("Choose single or multiplayer.");
            listBoxFeedback.Items.Add("Then press Begin Game to start!");
        }

        #region button event-handlers

        /// <summary>
        /// Closes the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing!");
            this.Close();
        }

        /// <summary>
        /// Allows the player to complete restart the game if they
        /// want to change single and multiplayer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            listBoxFeedback.Items.Clear();
            listBoxFeedback.Items.Add("You have started a brand new game.");

            //Let the user choose single or multplayer again
            radioButtonSinglePlayer.Enabled = true;
            radioButtonMultiPlayer.Enabled = true;

            //Disable every button so that they can completely start again
            buttonPlayCardPlayerOne.Enabled = false;
            buttonPlayCardPlayerTwo.Enabled = false;
            buttonRevealCards.Enabled = false;
            buttonEndRound.Enabled = false;
            buttonDealCards.Enabled = false;
        }

        /// <summary>
        /// Begins a game to play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBeginGame_Click(object sender, EventArgs e)
        {
            /*
                The following  code sets new instances of all
                the player objects.
                
                It depends on whether or not the player wants to 
                play a single or multiplayer game. 
                
                It will create the appropriate player or
                computer player object and initialise
                their hand.

                This code also resets all form labels and
                controls.
            */

            //Prepare the player 1 object for the new game
            player1 = new Player(listBoxPlayerOneBoard);
            player1.ClearHand();

            //If the player wants to play a single player game
            if (radioButtonSinglePlayer.Checked == true)
            {
                radioButtonMultiPlayer.Enabled = false;
                computerPlayer = new Computer(listBoxPlayerTwoBoard);
                computerPlayer.ClearHand();
            }
            //If the player wants to play with another player    
            else if (radioButtonMultiPlayer.Checked == true)
            {
                radioButtonSinglePlayer.Enabled = false;
                opponent = new Player(listBoxPlayerTwoBoard);
                opponent.ClearHand();
            }

            //Set the total points back to 0
            player1TotalPoints = 0;
            player2TotalPoints = 0;
            labelPlayerOneScore.Text = "0";
            labelPlayerTwoScore.Text = "0";

            //Clear the listboxes of any data
            listBoxPlayerOneHand.Items.Clear();
            listBoxPlayerOneBoard.Items.Clear();
            listBoxPlayerTwoHand.Items.Clear();
            listBoxPlayerTwoBoard.Items.Clear();
            listBoxFeedback.Items.Clear();

            //Enable buttons
            buttonDealCards.Enabled = true;

            //Create a new deck
            mainDeck.NewDeck();
            labelNumCards.Text = mainDeck.ToString();

            //Indicate to the player that the game has started
            listBoxFeedback.Items.Add("The deck has loaded.");
            listBoxFeedback.Items.Add("Round 1!");

            //Set game to round 1
            numRound = 1;
            labelRoundNumber.Text = numRound.ToString();

            //Reset all other labels
            labelPlayerOnePudding.Text = "0";
            labelPlayerTwoPudding.Text = "0";
        }

        /// <summary>
        /// Deals player and opponent a new hand.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDealCards_Click(object sender, EventArgs e)
        {
            DealCards();

            //Enable Player 1's button and disable opponent's hand
            buttonPlayCardPlayerOne.Enabled = false;
            buttonPlayCardPlayerTwo.Enabled = false;
            listBoxPlayerOneHand.Enabled = true;
            listBoxPlayerTwoHand.Enabled = false;

            //Give feedback to the player 
            listBoxFeedback.Items.Clear();
            listBoxFeedback.Items.Add("Cards have been dealt!");
            listBoxFeedback.Items.Add("It is now Player 1's turn.");

            //Load cards into the listbox and update deck label
            player1.UpdateHand(listBoxPlayerOneHand);

            //If playing multiplayer game
            if (radioButtonMultiPlayer.Checked)
                opponent.UpdateHand(listBoxPlayerTwoHand);

            //If player single player game
            else if (radioButtonSinglePlayer.Checked)
                computerPlayer.UpdateHand(listBoxPlayerTwoHand);

            labelNumCards.Text = mainDeck.ToString();

            //Disable the button so that players do not deal extra cards on accident
            buttonDealCards.Enabled = false;
        }

        /// <summary>
        /// Plays the selected card and puts in into the board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayCard_Click(object sender, EventArgs e)
        {
            bool playedChopsticks = player1.CheckForChopsticks();
            
            //Update the player's hand      
            player1.UpdateHand(listBoxPlayerOneHand);

            if (radioButtonMultiPlayer.Checked)
            {               
                //If the player decides to play a chopstick card
                if (playedChopsticks == true && player1.Hand.CardsInHandList.Count > 0)
                {
                    listBoxFeedback.Items.Clear();
                    listBoxFeedback.Items.Add("Player 1 has a chopstick card!");
                    listBoxFeedback.Items.Add("Play another card.");

                    //Enable button to allow the player to play another card
                    buttonPlayCardPlayerOne.Enabled = true;
                    buttonPlayCardPlayerTwo.Enabled = false;

                    //Enable player 1's listbox
                    listBoxPlayerOneHand.Enabled = true;
                    listBoxPlayerTwoHand.Enabled = false;                

                    playedChopsticks = false;
                }
                else
                {                  
                    //Give feedback to the player
                    listBoxFeedback.Items.Clear();
                    listBoxFeedback.Items.Add("Player 1 has selected a card.");
                    listBoxFeedback.Items.Add("It is now opponent's turn.");
                    
                    //Disable / enable buttons
                    buttonPlayCardPlayerOne.Enabled = false;

                    //Disable  / enable the player hand listbox
                    listBoxPlayerOneHand.Enabled = false;
                    listBoxPlayerTwoHand.Enabled = true;
                }
                //Play selected card
                player1.PlayCard();

                //Refresh player 1's board and Hand
                player1.UpdateHand(listBoxPlayerOneHand);
            }

            /*
                This code is only if the player is playing
                a single player game. 

                In a single player game the player will keep
                using the Play Card button.

                The computer will automatically select a card to 
                play.
           */

           else if(radioButtonSinglePlayer.Checked)
            {
                bool computerPlayedChopsticks = computerPlayer.CheckForChopsticks();

                //Give feedback to the players
                listBoxFeedback.Items.Clear();
                listBoxFeedback.Items.Add("Player 1" + player1.ToString());
                listBoxFeedback.Items.Add(computerPlayer.ToString());

                //Play and reveal the card that has been selected
                player1.PlayCard();
                player1.RevealCard();

                //Computer automatically picks what card to play
                computerPlayer.PlayCard();
                computerPlayer.RevealCard();
                computerPlayer.UpdateHand(listBoxPlayerTwoHand);

                SwapHands(computerPlayer);

                CheckRemainingCards(computerPlayer);
            }
        }

        /// <summary>
        /// opponent plays the selected card.
        /// Once opponent has played a card then players swap hands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayCardPlayerTwo_Click(object sender, EventArgs e)
        {           
            bool playedChopsticks = opponent.CheckForChopsticks();

            //If opponent has a chopsticks card in their hand they can play another card
            if (playedChopsticks == true && opponent.Hand.CardsInHandList.Count > 0)
            {
                listBoxFeedback.Items.Clear();
                listBoxFeedback.Items.Add("Player 2 has a chopstick card!");
                listBoxFeedback.Items.Add("Play another card.");

                //Allow the player to play another card
                buttonPlayCardPlayerTwo.Enabled = true;
                buttonPlayCardPlayerOne.Enabled = false;

                //Enable player 1's listbox
                listBoxPlayerTwoHand.Enabled = true;
                listBoxPlayerOneHand.Enabled = false;

                playedChopsticks = false;
            }
            else
            {
                //Give feedback to the player
                listBoxFeedback.Items.Clear();
                listBoxFeedback.Items.Add("Both players have selected a card.");
                listBoxFeedback.Items.Add("Please reveal your cards.");

                //disable / enable buttons
                buttonPlayCardPlayerTwo.Enabled = false;
                buttonRevealCards.Enabled = true;

                //Disable  / enable the player hand listbox
                listBoxPlayerOneHand.Enabled = false;
                listBoxPlayerTwoHand.Enabled = false;
            }
            //Opponent plays selected card
            opponent.PlayCard();

            //Refresh player 1's board and Hand
            opponent.UpdateHand(listBoxPlayerOneHand);
        }

        /// <summary>
        /// Ends the current round and starts the next round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEndRound_Click(object sender, EventArgs e)
        {
            //Calculate total points for player 1 and opponents
            player1TotalPoints += player1.CalcPoints();
            
            //If playing a multiplayer game
            if(radioButtonMultiPlayer.Checked)
            {
                player2TotalPoints += opponent.CalcPoints();
                CalcComparisonPoints(player1.TotalMakiRolls(), opponent.TotalMakiRolls(), 3);
            }
            //If playing a single player game   
            else if(radioButtonSinglePlayer.Checked)
            {
                player2TotalPoints += computerPlayer.CalcPoints();
                CalcComparisonPoints(player1.TotalMakiRolls(), computerPlayer.TotalMakiRolls(), 3);
            }                          

            //If the game is on the final round
            if (numRound == 3)
            {
                CalcComparisonPoints(player1.TotalPuddingCards(), opponent.TotalPuddingCards(), 0);

                //Display the total number of points
                labelPlayerOneScore.Text = player1TotalPoints.ToString();
                labelPlayerTwoScore.Text = player2TotalPoints.ToString();

                //Display the appropriate winning message
                if (player1TotalPoints > player2TotalPoints)
                    MessageBox.Show("Player 1 wins with " + player1TotalPoints + " points!");
                else if (player1TotalPoints < player2TotalPoints)
                    MessageBox.Show("Opponent wins with " + player2TotalPoints + " points!");
                else if (player1TotalPoints == player2TotalPoints)
                    MessageBox.Show("It is a tie!");

                //Give feedback to the player
                listBoxFeedback.Items.Clear();
                listBoxFeedback.Items.Add("That's the end of the game!");
                listBoxFeedback.Items.Add("Want to start a new game?");

                //Disable all buttons except for the new game button
                buttonDealCards.Enabled = false;
                buttonEndRound.Enabled = false;
                buttonPlayCardPlayerOne.Enabled = false;
                buttonPlayCardPlayerTwo.Enabled = false;
            }
            else
            {
                //Display the total number of points
                labelPlayerOneScore.Text = player1TotalPoints.ToString();
                labelPlayerTwoScore.Text = player2TotalPoints.ToString();

                //Clear the board and update the hand listboxes for the player
                player1.Board.ClearBoard();               
                player1.UpdateHand(listBoxPlayerOneHand);

                //Clear the board and update the hand listboxes for the opponent (depending on if it single or multiplayer)
                if(radioButtonSinglePlayer.Checked)
                {
                    computerPlayer.Board.ClearBoard();
                    computerPlayer.UpdateHand(listBoxPlayerTwoHand);
                }
                else if(radioButtonMultiPlayer.Checked)
                {
                    opponent.Board.ClearBoard();
                    opponent.UpdateHand(listBoxPlayerTwoHand);
                }

                //Display the total number of pudding cards
                labelPlayerOnePudding.Text = player1.TotalPuddingCards().ToString();

                //Display the total number of pudding cards (depending on if it is single or multiplayer)
                if(radioButtonSinglePlayer.Checked)
                    labelPlayerTwoPudding.Text = computerPlayer.TotalPuddingCards().ToString();
                else if (radioButtonMultiPlayer.Checked)
                    labelPlayerTwoPudding.Text = opponent.TotalPuddingCards().ToString();

                //Begin the new round
                numRound++;
                labelRoundNumber.Text = numRound.ToString();
                listBoxFeedback.Items.Clear();
                listBoxFeedback.Items.Add("Round " + numRound.ToString() + "!");
                listBoxFeedback.Items.Add("Deal more cards.");

                //Enable the deal cards button while disabling the new round button
                buttonDealCards.Enabled = true;
                buttonEndRound.Enabled = false;
            }           
        }

        /// <summary>
        /// Reveals what card each player has selected.
        /// It then puts that card into each player's
        /// board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRevealCards_Click(object sender, EventArgs e)
        {
            player1.RevealCard();
            opponent.RevealCard();

            //Give feedback to the players
            listBoxFeedback.Items.Clear();
            listBoxFeedback.Items.Add("Cards have been revealed!");
            listBoxFeedback.Items.Add("Hands have been swapped.");

            //Swap hands
            SwapHands(opponent);

            //Check if players have anymore cards
            CheckRemainingCards(opponent);          

            listBoxPlayerOneHand.Enabled = true;
            buttonRevealCards.Enabled = false;
        }

        #endregion

        #region listBox event-handlers

        /// <summary>
        /// When player 1 selects an item in the listbox
        /// it will indicate it in the feedback listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPlayerHand_SelectedIndexChanged(object sender, EventArgs e)
        {
            player1.SelectedCardIndex = listBoxPlayerOneHand.SelectedIndex;

            listBoxFeedback.Items.Clear();
            listBoxFeedback.Items.Add("Player 1 has selected a card.");
            buttonPlayCardPlayerOne.Enabled = true;
        }

        /// <summary>
        /// When opponent selects an item in the listbox
        /// it will indicate it in the feedback listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxComputerHand_SelectedIndexChanged(object sender, EventArgs e)
        {
            opponent.SelectedCardIndex = listBoxPlayerTwoHand.SelectedIndex;

            listBoxFeedback.Items.Clear();
            listBoxFeedback.Items.Add("Opponent has selected a card.");
            buttonPlayCardPlayerTwo.Enabled = true;
        }

        #endregion

        #region radioButton event-handlers

        /// <summary>
        /// Starts a new single player game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSinglePlayer_CheckedChanged(object sender, EventArgs e)
        {
            buttonBeginGame.Enabled = true;

            listBoxFeedback.Items.Clear();
            listBoxFeedback.Items.Add("Do you wish to play by yourself?");
        }

        /// <summary>
        /// Starts a new multiplayer game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMultiPlayer_CheckedChanged(object sender, EventArgs e)
        {
            buttonBeginGame.Enabled = true;

            listBoxFeedback.Items.Clear();
            listBoxFeedback.Items.Add("Looks like you have someone to play with.");
        }

        #endregion

        #endregion

     
    }
}
