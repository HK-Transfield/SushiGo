using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SushiGo
{
    class Computer : Player
    {
        //####################################################################
        //# Instance Variables  
        /// <summary>
        /// A random variable to generate a random card to play.
        /// </summary>
        private Random _randomSelect;

        /// <summary>
        /// The random variable that will be used to play the card
        /// </summary>
        private int _randCard;

        //####################################################################
        //# Constructor  
        /// <summary>
        /// Initialises a new Computer Player object.
        /// </summary>
        /// <param name="playArea">The area where the computer plays their card</param>
        public Computer(ListBox playArea) : base(playArea)
        {
            _randomSelect = new Random();
        }

        //####################################################################
        //# Public Methods  
        /// <summary>
        /// Automatically selects a card to play at random.
        /// </summary>
        public override void PlayCard()
        {
            _randCard = _randomSelect.Next(0, Hand.CardsInHandList.Count);

            PlaceOnWasabi();

            Board.AddCard(Hand.CardsInHandList[_randCard]);
            Hand.CardsInHandList.RemoveAt(_randCard);
        }

        /// <summary>
        /// Gets the card that the computer has played as a string.
        /// </summary>
        /// <returns>The card that the computer has played</returns>
        public override string ToString()
        {
            return "Computer played a card.";
        }
    }
}
