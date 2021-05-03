using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiGo
{
    class Board
    {
        //####################################################################
        //# Instance Variables
        /// <summary>
        /// List of cards that the player plays.
        /// </summary>
        protected List<Card> _cardsPlayedList, _discardPileList;

        /// <summary>
        /// A listbox is used as the playing area where
        /// the selected users card is place into.
        /// </summary>
        protected ListBox _playArea;

        //####################################################################
        //# Constructor   
        /// <summary>
        /// Initialises a new Board object.
        /// </summary>
        /// <param name="playArea">The listbox that represents the board</param>
        public Board(ListBox playArea)
        {
            _cardsPlayedList = new List<Card>();
            _discardPileList = new List<Card>();
            _playArea = playArea;
        }

        //####################################################################
        //# Read / Write Properties
        /// <summary>
        /// Gets and sets the cards that are played.
        /// </summary>
        public List<Card> CardsPlayedList
        {
            get { return _cardsPlayedList; }
            set { _cardsPlayedList = value; }
        }

        /// <summary>
        /// Gets the Discard Pile of cards.
        /// </summary>
        public List<Card> DiscardPileList
        {
            get { return _discardPileList; }
        }

        /// <summary>
        /// Gets the Play Area where the places their card.
        /// </summary>
        public ListBox PlayArea
        {
            get { return _playArea; }
        }

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Adds a card to the Board.
        /// </summary>
        /// <param name="c">The card to be played</param>
        public void AddCard(Card c)
        {
            CardsPlayedList.Add(c);           
        }

        /// <summary>
        /// Finds if there is a wasabi card in the board.
        /// </summary>
        /// <returns>The index position of the wasabi card</returns>
        public int GetWasabiIndex()
        {
            int wasabiIndex = 0;

            for(int i = 0; i < CardsPlayedList.Count; i++)
            {
                if (CardsPlayedList[i] is Wasabi)
                {
                    wasabiIndex = i;
                }
            }
            return wasabiIndex;
        }

        /// <summary>
        /// Checks if there is a wasabi card in the board.
        /// </summary>
        /// <returns>Whether there is a Wasabi Card or not</returns>
        public bool CheckForWasabi()
        {
            foreach(Card c in CardsPlayedList)
            {
                if (c is Wasabi)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Refreshs and updates the play area
        /// </summary>
        public void Refresh()
        {
            PlayArea.Items.Clear();

            foreach(Card c in CardsPlayedList)
            {
                PlayArea.Items.Add(c);
            }
        }
        
        /// <summary>
        /// Takes all cards in a players hand,
        /// and moves them to the discard pile.
        /// </summary>
        public void ClearBoard()
        {
            //Move all the cards from the board and into the discard pile.
            for(int i = 0; i < CardsPlayedList.Count; i++)            
                DiscardPileList.Add(CardsPlayedList[i]);                      

            //Clear the list of cards played
            CardsPlayedList.Clear();

            //Clear the listbox
            PlayArea.Items.Clear();
        }
    }
}
