using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Dumpling : Card
    {
        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises a new Dumpling Card Object.
        /// </summary>
        public Dumpling(){}

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Gets the name of the dumpling card.
        /// </summary>
        /// <returns>The name Dumpling Card</returns>
        public override string ToString()
        {
            return "Dumpling Card";
        }
    }
}
