using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingCards
{
    /// <summary>
    /// WeddingCard - a wedding greeting card. Inherits GreetingCard.
    /// </summary>
    internal class WeddingCard : GreetingCard
    {
        // Constructor: the recipient must be "<bride> & <groom>".
        public WeddingCard(string bride, string groom, string sender): base(bride + " & " + groom, sender)
        {
            SetRecipient(bride, groom);//if null must be empry string.
        }

        // Updates the recipient name.
        // Note: this is a second SetRecipient with different parameters (overloading).
        public void SetRecipient(string bride, string groom)
        {
            if (bride != null && groom != null)
                base.SetRecipient(bride + " & " + groom);
            else//for if null put in - we want to have 2 real strings
                base.SetRecipient("");
        }

        // Overrides GreetingCard.GreetingMsg().
        // Required result: "May you live happily ever after"
        protected override string GreetingMsg()
        {
            return "May you live happily ever after";
        }
    }
}
