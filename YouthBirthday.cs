using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingCards
{
    /// <summary>
    /// YouthBirthday - a child's birthday card. Inherits BirthdayCard.
    /// </summary>
    internal class YouthBirthday : BirthdayCard
    {
        public YouthBirthday(string recipient, string sender, int age) : base(recipient, sender, age)
        {//empty beacause all veribals are checked in base classes.
        }

        // Overrides BirthdayCard.GreetingMsg().
        // Required result:
        // Happy Birthday! You are <age> today!
        // How you have grown!!
        protected override string GreetingMsg()
        {
            return base.GreetingMsg() +
                "\nHow you have grown!!";
        }
    }
}
