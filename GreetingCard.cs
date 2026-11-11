using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingCards
{
    /// <summary>
    /// GreetingCard - the base class: a general greeting card.
    /// </summary>
    internal class GreetingCard
    {
        private string recipient;
        private string sender;

        // Constructor: creates a greeting card from the given parameters.
        public GreetingCard(string recipient, string sender)
        {
            if(recipient != null)
                this.recipient = recipient;
            else
                this.recipient = "";
            if (sender != null)
                this.sender = sender;
            else
                this.sender = "";
        }

        public void SetRecipient(string recipient)
        {
            if (recipient != null)
            {
                this.recipient = recipient;
            }
        }

        // Returns the greeting text that appears in the card.
        // Required result: "Best Greetings!"
        protected virtual string GreetingMsg()
        {
            // TODO
            return "";
        }

        // Returns the whole card. Must CALL GreetingMsg() for the greeting line.
        // Required result:
        // Dear <recipient>,
        // <the greeting from GreetingMsg()>
        // <sender>
        // ********************************
        public override string ToString()
        {
            // TODO
            return "";
        }
    }
}
