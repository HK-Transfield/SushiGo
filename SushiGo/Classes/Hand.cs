using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Hand
    {
        //####################################################################
        //# Instance Variables
        /// <summary>
        /// A list of all the cards contained in a hand.
        /// </summary>
        private List<Card> _cardsInHandList;

        /// <summary>
        /// The maximum number of cards allowed in a hand.
        /// </summary>
        private const int MAX_CARDS = 10;

        //####################################################################
        //# Constructor   
        /// <summary>
        /// Initialises a new Hand Object.
        /// </summary>
        public Hand()
        {
            _cardsInHandList = new List<Card>(MAX_CARDS);
        }

        //####################################################################
        //# Read / Write Properties
        /// <summary>
        /// Gets and sets the list of cards in a hand.
        /// </summary>
        public List<Card> CardsInHandList
        {
            get { return _cardsInHandList; }
            set { _cardsInHandList = value; }
        }

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Adds a new card to the Hand.
        /// </summary>
        /// <param name="c"></param>
        public void AddCard(Card c)
        {
            CardsInHandList.Add(c);
        }
    }
}
