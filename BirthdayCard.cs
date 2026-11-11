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
            if(age > 0)//real age
                this.age = age;
            else//if not real age than basic will be 0.
                this.age = 0;
        }

        // Overrides GreetingCard.GreetingMsg().
        // Required result: "Happy Birthday! You are <age> today!"
        protected override string GreetingMsg()
        {
            return "Happy Birthday! You are " + this.age + " today!";
        }
    }
}
