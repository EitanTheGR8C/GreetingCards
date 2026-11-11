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
        public GreetingCard(string recipient, string sender)//if null I chose to have it as an empty string so no need to work with nulls.
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

        // Updates the recipient name.
        public void SetRecipient(string recipient)
        {
            if (recipient != null)//same done for constructor
            {
                this.recipient = recipient;
            }
        }

        // Returns the greeting text that appears in the card.
        // Required result: "Best Greetings!"
        protected virtual string GreetingMsg()
        {
            return "Best Greetings!";
        }

        // Returns the whole card.
        // Required result:
        // Dear <recipient>,
        // <the greeting from GreetingMsg()>
        // <sender>
        // ********************************
        public override string ToString()
        {
            return $"Dear " + this.recipient + "," +
                  "\n" + GreetingMsg() + 
                  "\n" + this.sender;
        }
    }
}
