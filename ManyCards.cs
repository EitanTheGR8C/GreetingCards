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


        // Parts A+B, Question 1
        // What is the relationship between AdultBirthday, YouthBirthday and BirthdayCard?
        // Answer:
        // BirthdayCard is the base class (super class) and AdultBirthday and YouthBirthday are its
        // derived classes (sub classes). Each of them inherits from BirthdayCard
        // (AdultBirthday : BirthdayCard, YouthBirthday : BirthdayCard). It is an "is a" relationship:
        // an AdultBirthday is a BirthdayCard, and a YouthBirthday is a BirthdayCard.
        // AdultBirthday and YouthBirthday are siblings, neither inherits from the other.
        //
        // Parts A+B, Question 2
        // What is the relationship between AdultBirthday, YouthBirthday and GreetingCard?
        // Answer:
        // GreetingCard is the top base class of the tree. AdultBirthday and YouthBirthday inherit
        // from it indirectly: they inherit from BirthdayCard, which inherits from GreetingCard.
        // So GreetingCard is their grandparent class (an indirect base class), and each of them
        // is a GreetingCard as well as a BirthdayCard.
        //
        // Parts A+B, Question 3
        // Which methods can an object of type GreetingCard invoke?
        // Answer:
        // From Main, a GreetingCard object can invoke the public methods:
        // - SetRecipient(string recipient)
        // - ToString()
        // It also has the public methods every class gets from Object (Equals, GetHashCode, GetType).
        // GreetingMsg() is protected, so it exists in the object, but Main cannot call it on the
        // object. It can only be called from inside GreetingCard or from a class that inherits
        // from it. ToString() calls it internally.
        //
        // Parts A+B, Question 4
        // Which methods can an object of type AdultBirthday invoke?
        // Answer:
        // From Main, an AdultBirthday object can invoke the public methods it inherited:
        // - SetRecipient(string recipient), inherited from GreetingCard
        // - ToString(), inherited from GreetingCard (AdultBirthday and BirthdayCard do not override it)
        // It also has the public methods from Object (Equals, GetHashCode, GetType).
        // AdultBirthday does not have the SetRecipient(string bride, string groom) method,
        // because that one exists only in WeddingCard.
        // GreetingMsg() is protected, so Main cannot call it. The AdultBirthday class itself can
        // call it, and it also calls base.GreetingMsg() from inside its own GreetingMsg().
        //
        // Parts A+B, Question 5
        // How many methods named SetRecipient(...) does the WeddingCard class have?
        // Which mechanism allows this?
        // Answer:
        // Two:
        // - SetRecipient(string recipient), inherited from GreetingCard
        // - SetRecipient(string bride, string groom), defined in WeddingCard
        // The mechanism is overloading. The methods have the same name but different parameter
        // lists (one string versus two strings), so the compiler knows which one to call from
        // the arguments. This is not overriding, because the signature is different and the new
        // method does not replace the inherited one.
        //
        // Parts A+B, Question 6
        // Explain how each call to ToString() is carried out in the code:
        //   AdultBirthday adultBirth = new AdultBirthday("Joe", "Marry", 50);
        //   GreetingCard gc = new GreetingCard("Debby", "Dan");
        //   WeddingCard wc = new WeddingCard("Joe", "Marry", "Debby");
        //   Console.WriteLine(gc);
        //   Console.WriteLine(wc);
        //   Console.WriteLine(adultBirth);
        // Answer:
        // Console.WriteLine(object) calls ToString() on the object it receives. Only GreetingCard
        // defines ToString(). No other class overrides it, so all three calls run the same
        // GreetingCard.ToString() code. Inside it, the call to GreetingMsg() is virtual, so the
        // version that runs depends on the real type of the object:
        // 1. Console.WriteLine(gc): the object is a GreetingCard, so GreetingMsg() of GreetingCard
        //    runs and the card shows "Best Greetings!".
        // 2. Console.WriteLine(wc): WeddingCard has no ToString(), so it uses the inherited
        //    GreetingCard.ToString(). Inside it, GreetingMsg() runs the WeddingCard override,
        //    which returns "May you live happily ever after". The recipient is "Joe & Marry".
        // 3. Console.WriteLine(adultBirth): AdultBirthday and BirthdayCard have no ToString(),
        //    so it uses the inherited GreetingCard.ToString(). GreetingMsg() runs the
        //    AdultBirthday override. It calls base.GreetingMsg() of BirthdayCard
        //    ("Happy Birthday! You are 50 today!") and adds a new line with
        //    "You haven't changed at all!".
        //
        // Parts A+B, Question 7
        // Why was GreetingMsg() defined protected and not public? What would change if it were public?
        // Answer:
        // GreetingMsg() is only a helper for building the card. It is meant to be used by
        // ToString() inside GreetingCard, and by the derived classes, which override it and call
        // base.GreetingMsg(). Protected means it can be used only inside the class and the
        // classes that inherit from it, so code outside (like Main) cannot call it. This keeps
        // the object's inside hidden (encapsulation), and the outside world uses only ToString()
        // to get the whole card.
        // If it were public, any code, such as Main, could call card.GreetingMsg() directly and
        // get only the greeting without the Dear line, sender and stars. The class would then
        // show more than it needs to, and the way the card is built would be part of its public
        // interface.
        //
        // Parts A+B, Question 8
        // Will this code compile? Explain.
        //   GreetingCard gc = new BirthdayCard("Joe", "Marry", 30);
        //   string s = gc.GreetingMsg();
        // Answer:
        // The first line compiles. A BirthdayCard is a GreetingCard, so it can be stored in a
        // GreetingCard variable (upcasting).
        // The second line does not compile. GreetingMsg() is protected, and this code is written
        // outside the GreetingCard hierarchy (for example in Main), so it has no permission to
        // call it. The compiler checks access by the type of the variable (GreetingCard), and
        // the method is protected there. The fact that the real object is a BirthdayCard does
        // not change that. The error is that GreetingMsg() is inaccessible due to its
        // protection level.
        //
        // Part C, Question 1
        // Explain which method is executed each time you call ToString() while scanning the array.
        // Answer:
        // Every card in the array is stored as a GreetingCard, but the call is always to the
        // same GreetingCard.ToString(), because no class overrides it. Inside it, the call to
        // GreetingMsg() is decided at run time by the real type of the object (dynamic binding):
        // - GreetingCard object: GreetingCard.GreetingMsg()
        // - BirthdayCard object: BirthdayCard.GreetingMsg()
        // - WeddingCard object: WeddingCard.GreetingMsg()
        // - YouthBirthday object: YouthBirthday.GreetingMsg(), which also calls BirthdayCard's
        //   version first
        // - AdultBirthday object: AdultBirthday.GreetingMsg(), which also calls BirthdayCard's
        //   version first
        // So each card prints its own greeting.
        //
        // Part C, Question 2
        // Name one place in your program where you performed upcasting.
        // Answer:
        // In ManyCards.Main, in the line:
        //   cards[1] = new BirthdayCard("Yossi", "Eitan", 16);
        // A BirthdayCard object is put into an array cell of type GreetingCard, so it is
        // converted up the inheritance tree to its base class. The same happens with the
        // WeddingCard, YouthBirthday and AdultBirthday lines. It is done automatically,
        // without writing a cast.
        //
        // Part C, Question 3
        // Did you perform downcasting in your program? If so, where?
        // Answer:
        // No. The program never converts a GreetingCard back to a BirthdayCard, WeddingCard or
        // any other derived type. It was not needed, because ToString() is called on the
        // GreetingCard variables and each object runs its own GreetingMsg() automatically.
        //
        // Part C, Question 4
        // Which object-oriented principles allowed you to call the same method but get different
        // behavior from objects of different classes? (Name two.)
        // Answer:
        // 1. Inheritance
        // 2. Polymorphism (done with method overriding, using virtual and override)
        //
        // Part C, Question 5
        // Briefly explain each principle you named in Question 4.
        // Answer:
        // Inheritance: a class can take over the fields and methods of another class and add or
        // change things. BirthdayCard, WeddingCard and the other cards inherit from
        // GreetingCard, so they get SetRecipient() and ToString() without rewriting them, and
        // every one of them can be treated as a GreetingCard.
        // Polymorphism: the same call can behave differently depending on the real type of the
        // object. GreetingMsg() is marked virtual in GreetingCard and each derived class
        // overrides it. When ToString() calls GreetingMsg() on an object in the GreetingCard[]
        // array, C# picks the version of the real object at run time, so each card prints its
        // own greeting.
    }
}
