using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Chopsticks : Card
    {
        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises a new Chopstick Card object.
        /// </summary>
        public Chopsticks(){}

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Gets the name of the Card.
        /// </summary>
        /// <returns>The Name of the card as a string</returns>
        public override string ToString()
        {
            return "Chopsticks Card";
        }
    }
}
