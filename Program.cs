using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingCards
{
    internal class Program
    {
        /// <summary>
        /// Program - the test program for parts A and B.
        /// Part C note: when you build ManyCards, comment out this Main and uncomment
        /// the Main inside ManyCards.cs (only one Main can be active at a time).
        /// </summary>
        static void Main(string[] args)
        {
            // PART A TEST:
            GreetingCard card1 = new GreetingCard("Yossi", "Eitan");
            BirthdayCard card2 = new BirthdayCard("Ophir", "Eitan", 20);
            WeddingCard card3 = new WeddingCard("Shmuel", "Ido", "Eitan");

            Console.WriteLine(card1);
            Console.WriteLine(card2);
            Console.WriteLine(card3);

            // PART B TEST (after you finish part B): create at least one YouthBirthday
            YouthBirthday card4 = new YouthBirthday("Mila", "Eitan", 15);
            AdultBirthday card5 = new AdultBirthday("Dad", "Eitan", 45);

            Console.WriteLine(card4);
            Console.WriteLine(card5);

        }
    }
}
