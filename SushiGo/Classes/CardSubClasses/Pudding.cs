using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Pudding : Card
    {
        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises a new Pudding Card object.
        /// </summary>
        public Pudding(){}

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Gets the name of the Pudding Card.
        /// </summary>
        /// <returns>The name Pudding Card</returns>
        public override string ToString()
        {
            return "Pudding Card";
        }
    }
}
