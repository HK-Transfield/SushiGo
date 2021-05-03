using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Wasabi : Card
    {
        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises a new Wasabi Card object.
        /// </summary>
        public Wasabi(){}

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Gets the name of the card.
        /// </summary>
        /// <returns>The name Wasabi Card</returns>
        public override string ToString()
        {
            return "Wasabi Card";
        }
    }
}
