using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingCards
{
    /// <summary>
    /// BirthdayCard - a birthday greeting card. Inherits GreetingCard.
    /// </summary>
    internal class BirthdayCard : GreetingCard
    {
        private int age;

        // Constructor: recipient and sender go to GreetingCard through base(...).
        public BirthdayCard(string recipient, string sender, int age) : base(recipient, sender)
        {
            // TODO: store age
        }

        // Overrides GreetingCard.GreetingMsg().
        // Required result: "Happy Birthday! You are <age> today!"
        protected override string GreetingMsg()
        {
            // TODO
            return "";
        }
    }
}
