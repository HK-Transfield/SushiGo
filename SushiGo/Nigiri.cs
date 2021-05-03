using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SushiGo
{
    class Nigiri : Card
    {
        public enum NigiriType {Salmon, Squid, Egg}
        protected bool _onWasabi;
        protected NigiriType _type;

        /// <summary>
        /// Initialise a new Nigiri card
        /// </summary>
        /// <param name="type"></param>
        public Nigiri(string type)
        {
            _type = (NigiriType)Enum.Parse(typeof(NigiriType), type);
        }

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

        /// <summary>
        /// Gets the name of the card.
        /// </summary>
        /// <returns>The name of the Nigiri Card</returns>
        public override string ToString()
        {
            return Type.ToString() + " Nigiri Card";
        }
    }
}
