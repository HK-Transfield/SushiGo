using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SushiGo
{
    class Player
    {
        //####################################################################
        //# Instance Variables 
        /// <summary>
        /// The hand of the player, which holds their cards.
        /// </summary>
        protected Hand _hand;

        /// <summary>
        /// The board of the player, where they play their selected card.
        /// </summary>
        protected Board _board;

        /// <summary>
        /// The points of a board has.
        /// </summary>
        private int _points;

        /// <summary>
        /// The index of the card that the player picks.
        /// </summary>
        private int _selectedCardIndex;

        //####################################################################
        //# Constructor   
        /// <summary>
        /// Initialises a new Player object.
        /// </summary>
        /// <param name="playArea"></param>
        public Player(ListBox playArea)
        {
            _hand = new Hand();
            _board = new Board(playArea);
            _points = 0;
        }

        //####################################################################
        //# Read / Write Properties 
        /// <summary>
        /// Gets and sets the Hand of the player.
        /// </summary>
        public Hand Hand
        {
            get { return _hand; }
            set { _hand = value; }
        }

        /// <summary>
        /// Gets and sets the baord of the player.
        /// </summary>
        public Board Board
        {
            get { return _board; }
            set { _board = value; }
        }

        /// <summary>
        /// Gets the number of points in a board.
        /// </summary>
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

        /// <summary>
        /// Gets and sets the selected card index.
        /// </summary>
       public int SelectedCardIndex
        {
            get { return _selectedCardIndex; }
            set { _selectedCardIndex = value; }
        }

        //####################################################################
        //# Public Methods 
        /// <summary>
        /// Calculates the number of points a player
        /// earns in a round.
        /// </summary>
        /// <returns>The number of points</returns>
        public int CalcPoints()
        {
            //Variables to count the number of instances of a card
            int tempuraCount = 0;
            int sashimiCount = 0;
            int dumplingCount = 0;

            foreach(Card c in Board.CardsPlayedList)
            {
                //If the card is a tempura
                if (c is Tempura)
                    tempuraCount++;

                //If the card is a sashimi
                if (c is Sashimi)
                    sashimiCount++;

                //If the card is a dumpling
                if (c is Dumpling)
                    dumplingCount++;

                //If the Card is a Nigiri card
                if(c is Nigiri)
                {
                    Nigiri n = (Nigiri)c;

                    if(n.OnWasabi == false)
                    {
                        //If it is an Egg Nigiri Card
                        if (n.Type == Nigiri.NigiriType.Egg)
                            Points++;

                        //If it is a Salmon Nigiri Card
                        if (n.Type == Nigiri.NigiriType.Salmon)
                            Points += 2;

                        //If it is a Squid Nigiri Card    
                        if (n.Type == Nigiri.NigiriType.Squid)
                            Points += 3;
                    }
                    else if(n.OnWasabi == true)
                    {
                        //If it is an Egg Nigiri Card that is on a Wasabi
                        if (n.Type == Nigiri.NigiriType.Egg)
                            Points += 3;

                        //If it is a Salmon Nigiri Card that is on a Wasabi
                        if (n.Type == Nigiri.NigiriType.Salmon)
                            Points += 6;

                        //If it is a Squid Nigiri Card that is on a Wasabi    
                        if (n.Type == Nigiri.NigiriType.Squid)
                            Points += 9;
                    }                  
                }
            }

            //Calculate the number of points for each set of 2 tempura cards
            if (tempuraCount % 2 == 0)
                Points +=  (tempuraCount / 2) * 5;

            //Calculate the number of points for each set of 3 sashimi cards
            if (sashimiCount % 3 == 0)
                Points += (sashimiCount /3) * 10;

            //Calculate the number of points based on the number dumpling cards a player has
            if (dumplingCount == 1)
                Points++;
            else if (dumplingCount == 2)
                Points += 3;
            else if (dumplingCount == 3)
                Points += 6;
            else if (dumplingCount == 4)
                Points += 10;
            else if (dumplingCount <= 5)
                Points += 15;
            
            return Points;
        }

        /// <summary>
        /// Gets the total number of maki rolls on the board.
        /// </summary>
        public int TotalMakiRolls()
        {
            int totalMakiRolls = 0;

            //Checks every card in that has been played
            foreach(Card c in Board.CardsPlayedList)
            {
                //If there is a maki roll card add it to the total count
                if(c is MakiRolls)
                {
                    MakiRolls m = (MakiRolls)c;
                    totalMakiRolls += m.MakiValue;
                }
            }
            return totalMakiRolls;
        }

        /// <summary>
        /// Gets the total number of pudding cards the player has played.
        /// </summary>
        /// <returns>The total number of pudding cards</returns>
        public int TotalPuddingCards()
        {
            int puddingCount = 0;

            //Checks for all Pudding Cards the player has played
            foreach(Card c in Board.DiscardPileList)
            {
                if (c is Pudding)
                    puddingCount++;
            }
            return puddingCount;
        }
        
        /// <summary>
        /// Places Nigiri Card on top of a Wasabi Card.
        /// </summary>
        protected void PlaceOnWasabi()
        {
            //Checks if there is a Wasabi card already on the board
            if (Hand.CardsInHandList[SelectedCardIndex] is Nigiri && Board.CheckForWasabi() == true)
            {
                Nigiri n = (Nigiri)Hand.CardsInHandList[SelectedCardIndex];

                n.OnWasabi = true;

                //Place the Nigiri Card on top of the Wasabi and remove wasabi card from list
                Board.CardsPlayedList.RemoveAt(Board.GetWasabiIndex());
                Board.PlayArea.Items.Insert(Board.GetWasabiIndex() + 1, n.ToString());
                Board.Refresh();
            }
        }

        /// <summary>
        /// Updates all the cards in a players hand into the game.
        /// </summary>
        /// <param name="playerHand">The listbox to display all the cards in</param>
        public virtual void UpdateHand(ListBox listBoxHand)
        {
            listBoxHand.Items.Clear();

            //For each card in the hand display it to the listbox
            foreach(Card c in Hand.CardsInHandList)
            {
                listBoxHand.Items.Add(c.ToString());
            }
        }

        /// <summary>
        /// Puts the selected card onto the board.
        /// </summary>
        /// <param name="cardIndex">The index position of the card in the hand</param>
        public virtual void PlayCard()
        {
            PlaceOnWasabi();

            //Remove the card from the hand
            Board.AddCard(Hand.CardsInHandList[SelectedCardIndex]);
            Hand.CardsInHandList.RemoveAt(SelectedCardIndex);         
        }

        /// <summary>
        /// Reveals the cards that the player has played on the board.
        /// </summary>
        public void RevealCard()
        {
            Board.PlayArea.Items.Clear();

            //For each card that has been played
            foreach(Card c in Board.CardsPlayedList)
            {
                //Add it to the play area of the board
                Board.PlayArea.Items.Add(c.ToString());
            }
        }

        /// <summary>
        /// Allows players to play another card in their hand 
        /// if they have a chopsticks card on the board.
        /// </summary>
        /// <returns>Whether there is a chopsticks card in the player's hand</returns>
        public virtual bool CheckForChopsticks()
        {
            foreach(Card c in Board.CardsPlayedList)
            {
                //Check if there is a chopsticks card in the board
                if (c is Chopsticks)
                {
                    Hand.CardsInHandList.Add(c);
                    Board.CardsPlayedList.Remove(c);
                    Board.Refresh();
                    return true;
                }                   
            }
            return false;
        }

        /// <summary>
        /// Loads the players hands with cards.
        /// </summary>
        public void InitialiseHand(Card c)
        {
            Hand.CardsInHandList.Add(c);
        }

        /// <summary>
        /// Clears the hand of any cards it has left.
        /// </summary>
        public void ClearHand()
        {
            Hand.CardsInHandList.Clear();
        }

        public override string ToString()
        {
            return " has played a " + Hand.CardsInHandList[SelectedCardIndex];
        }
    }
}
