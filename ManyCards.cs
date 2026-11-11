using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingCards
{
    /// <summary>
    /// ManyCards - part C: polymorphism. This class holds Main and a GreetingCard[] array.
    /// NOTE: only ONE Main can be active in the project. 
    /// </summary>
    internal class ManyCards
    {
        static void Main(string[] args)
        {
            GreetingCard[] cards = new GreetingCard[5];

            cards[0] = new GreetingCard("Yossi", "Eitan");
            cards[1] = new BirthdayCard("Ophir", "Eitan", 20);
            cards[2] = new WeddingCard("Shmuel", "Ido", "Eitan");
            cards[3] = new YouthBirthday("Mila", "Eitan", 15);
            cards[4] = new AdultBirthday("Dad", "Eitan", 45);

            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine(cards[i]);
            }
        }
    }
}
