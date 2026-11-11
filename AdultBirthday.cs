using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingCards
{
    /// <summary>
    /// AdultBirthday - an adult's birthday card. Inherits BirthdayCard.
    /// </summary>
    internal class AdultBirthday: BirthdayCard
    {
        public AdultBirthday(string recipient, string sender, int age) : base(recipient, sender, age)
        {//same as YouthBirthday
        }

        // Overrides BirthdayCard.GreetingMsg().
        // Required result:
        // Happy Birthday! You are <age> today!
        // You haven't changed at all!
        protected override string GreetingMsg()
        {
            return base.GreetingMsg() +
                "\nYou haven't changed at all!";
        }
    }
}
