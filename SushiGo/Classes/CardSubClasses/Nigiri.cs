using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Nigiri : Card
    {
        //####################################################################
        //# Instance Variables
        /// <summary>
        /// The 3 types of Nigiri Cards in the game.
        /// </summary>
        public enum NigiriType {Salmon, Squid, Egg}

        /// <summary>
        /// Checks whether the Nigiri has been placed on top
        /// of a Wasabi card.
        /// </summary>
        protected bool _onWasabi;

        /// <summary>
        /// The type of the Nigiri Card.
        /// </summary>
        protected NigiriType _type;

        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialise a new Nigiri card object.
        /// </summary>
        /// <param name="type"></param>
        public Nigiri(string type)
        {
            _type = (NigiriType)Enum.Parse(typeof(NigiriType), type);
        }

        //####################################################################
        //# Read / Write Properties
        /// <summary>
        /// Gets and sets whether there is a Wasabi card to
        /// play the Nigiri gard on.
        /// </summary>
        public bool OnWasabi
        {
            get { return _onWasabi; }
            set { _onWasabi = value; }
        }

        /// <summary>
        /// Gets the type of Nigiri card.
        /// </summary>
        public NigiriType Type
        {
            get { return _type; }
        }

        //####################################################################
        //# Public Methods
        /// <summary>
        /// Gets the name of the card.
        /// </summary>
        /// <returns>The name of the Nigiri Card</returns>
        public override string ToString()
        {
            if(OnWasabi == true)
                return Type.ToString() + " Nigiri Card (W)";           
            else
                return Type.ToString() + " Nigiri Card";
        }
    }
}
