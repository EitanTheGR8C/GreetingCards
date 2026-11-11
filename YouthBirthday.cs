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
        {
        }

        // Overrides BirthdayCard.GreetingMsg().
        // Do NOT copy the first greeting line: call base.GreetingMsg() and add the
        // second line to its result (use Environment.NewLine to move to a new line).
        // Required result:
        // Happy Birthday! You are <age> today!
        // How you have grown!!
        protected override string GreetingMsg()
        {
            // TODO
            return "";
        }
    }
}
