using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Sashimi : Card
    {
        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises a new Sashimi Card object.
        /// </summary>
        public Sashimi(){}

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Gets the name of the Sashimi Card.
        /// </summary>
        /// <returns>The name Sashimi Card</returns>
        public override string ToString()
        {
            return "Sashimi Card";
        }
    }
}
