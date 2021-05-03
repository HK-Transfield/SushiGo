using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class MakiRolls : Card
    {
        //####################################################################
        //# Instance Variables
        /// <summary>
        /// The value that the Maki Roll card contains (1, 2, 3).
        /// </summary>
        private int _makiValue;

        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises a new Maki Rolls Card object.
        /// </summary>
        /// <param name="makiValue">The number of maki rolls in the card</param>
        public MakiRolls(int makiValue)
        {
            _makiValue = makiValue;
        }

        //####################################################################
        //# Read / Write Properties
        /// <summary>
        /// Gets and sets the value of Maki Rolls card.
        /// </summary>
        public int MakiValue
        {
            get { return _makiValue; }
        }

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Gets the name of the Maki Roll card.
        /// </summary>
        /// <returns>The value and name of the maki </returns>
        public override string ToString()
        {
            return MakiValue.ToString() + " Maki Roll Card";
        }
    }
}
