using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Tempura : Card
    {
        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises a new Tempura Card Object
        /// </summary>
        public Tempura(){}

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Gets the name of the Tempura Card.
        /// </summary>
        /// <returns>The name Tempura Card</returns>
        public override string ToString()
        {
            return "Tempura Card";
        }
    }
}
