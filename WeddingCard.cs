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
        public WeddingCard(string bride, string groom, string sender)
            : base(bride + " & " + groom, sender)
        {
        }

        // Updates the recipient name.
        // Note: this is a SECOND SetRecipient with different parameters (overloading).
        public void SetRecipient(string bride, string groom)
        {
            // TODO
        }

        // Overrides GreetingCard.GreetingMsg().
        // Required result: "May you live happily ever after"
        protected override string GreetingMsg()
        {
            // TODO
            return "";
        }
    }
}
