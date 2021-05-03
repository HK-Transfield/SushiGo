using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Deck
    {
        //####################################################################
        //# Instance Variables
        /// <summary>
        /// List of all the cards in the deck.
        /// </summary>
        private List<Card> _deckContents;

        /// <summary>
        /// The maximum number of cards that a deck
        /// holds, based of the rules of the game.
        /// </summary>
        private const int MAX_DECK_CARDS = 108;

        /// <summary>
        /// Initialises a new Deck object.
        /// </summary>
        public Deck()
        {
            _deckContents = new List<Card>(MAX_DECK_CARDS);
        }

        //####################################################################
        //# Constructor   
        /// <summary>
        /// Gets and sets the contents of the deck.
        /// </summary>
        public List<Card> DeckContents
        {
            get { return _deckContents; }
            set { _deckContents = value; }
        }

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Creates a new Deck.
        /// The number of each type of card is based off of the
        /// rules of the game.
        /// </summary>
        public void NewDeck()
        {
            //Clear the deck of any cards it still has
            DeckContents.Clear();

            //Adds 14 Tempura, Sashimi and Dumpling Cards to the deck
            for(int i = 1; i <= 14; i++)
            {
                DeckContents.Add(new Tempura());
                DeckContents.Add(new Sashimi());
                DeckContents.Add(new Dumpling());
            }

            //Adds 12 Two Maki Roll Cards to the deck
            for (int i = 1; i <= 12; i++)
                DeckContents.Add(new MakiRolls(2));

            //Adds 10 Salmon Nigiri and Pudding Cards to the deck
            for (int i = 1; i <= 10; i++)
            {
                DeckContents.Add(new Nigiri("Salmon"));
                DeckContents.Add(new Pudding());
            }

            //Adds 8 Three Maki Rolls cards to the deck
            for (int i = 1; i <= 8; i++)
                DeckContents.Add(new MakiRolls(3));

            //Adds 6 One Maki Rolls and Wasabi Cards to the deck
            for(int i = 1; i <= 6; i++)
            {
                DeckContents.Add(new MakiRolls(1));
                DeckContents.Add(new Wasabi());
            }

            //Adds 5 Squid Nigiri and Egg Nigiri Cards to the deck
            for(int i = 1; i <= 5; i++)
            {
                DeckContents.Add(new Nigiri("Squid"));
                DeckContents.Add(new Nigiri("Egg"));
            }

            //Adds 4 Chopsticks Cards to the deck
            for (int i = 1; i <= 4; i++)
                DeckContents.Add(new Chopsticks());
        }

        /// <summary>
        /// Gets the number of cards remaining in a deck.
        /// </summary>
        /// <returns>The number of cards in the deck</returns>
        public override string ToString()
        {
            return DeckContents.Count.ToString();
        }
    }
}
