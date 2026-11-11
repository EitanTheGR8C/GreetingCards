# Greeting Cards

A C# console project about **greeting cards**, built to practice class inheritance and polymorphism. A base class holds the common card data, and each card type inherits from it and changes only its greeting.

## Project Structure

```
GreetingCards/
├── GreetingCard.cs    # Base class - recipient, sender, ToString()
├── BirthdayCard.cs    # Birthday card with an age (inherits from GreetingCard)
├── WeddingCard.cs     # Wedding card with bride and groom (inherits from GreetingCard)
├── YouthBirthday.cs   # Birthday card for a child (inherits from BirthdayCard)
├── AdultBirthday.cs   # Birthday card for an adult (inherits from BirthdayCard)
├── Program.cs         # Test program for parts A and B (its Main is commented out)
└── ManyCards.cs       # Part C: Main + an array of cards, and the written answers
```

## Class Hierarchy

```
GreetingCard
├── BirthdayCard
│   ├── YouthBirthday
│   └── AdultBirthday
└── WeddingCard
```

## The Classes

### `GreetingCard` (base class)
Holds what every card shares: the recipient and the sender (both `private`). A `null` name becomes an empty string, so the class never works with nulls.

| Member | Description |
| --- | --- |
| `GreetingCard(recipient, sender)` | Creates a card |
| `SetRecipient(recipient)` | Changes the recipient (a `null` keeps the old one) |
| `GreetingMsg()` | `protected virtual` - returns `"Best Greetings!"` |
| `ToString()` | Builds the whole card: `Dear <recipient>,`, the greeting, the sender and a line of stars |

`ToString()` is written only here. It calls `GreetingMsg()`, so each card type shows its own greeting.

### `BirthdayCard : GreetingCard`
Adds an age (an age that is not above 0 becomes 1). Overrides `GreetingMsg()` to return `Happy Birthday! You are <age> today!`.

### `WeddingCard : GreetingCard`
The recipient is `<bride> & <groom>`. Adds a second `SetRecipient(bride, groom)` - this is **overloading** (same name, different parameters). Overrides `GreetingMsg()` to return `May you live happily ever after`.

### `YouthBirthday : BirthdayCard`
Overrides `GreetingMsg()`: the birthday line from `BirthdayCard` (through `base.GreetingMsg()`) plus `How you have grown!!`.

### `AdultBirthday : BirthdayCard`
Overrides `GreetingMsg()`: the birthday line from `BirthdayCard` (through `base.GreetingMsg()`) plus `You haven't changed at all!`.

## Concepts Practiced

- **Inheritance** - every card inherits `SetRecipient()` and `ToString()` from `GreetingCard`
- **Overriding** - `virtual` / `override` on `GreetingMsg()`
- **Overloading** - the two `SetRecipient` methods in `WeddingCard`
- **Polymorphism** - a `GreetingCard[]` array holds all card types, and each one prints its own greeting
- **Upcasting** - storing a derived card in a `GreetingCard` variable
- **Encapsulation** - `GreetingMsg()` is `protected`, so only the class and its subclasses can call it

## Running the Project

Open in **Visual Studio** (C# console app) and run.

**Only one `Main` can be active in the project.** As it is now, the active `Main` is the one in `ManyCards.cs` (part C). It creates five cards (one of each type) in a `GreetingCard[]` array and prints them in a loop.

To run the part A and B test instead, comment out the `Main` in `ManyCards.cs` and uncomment the `Main` in `Program.cs`. That one creates the cards one by one and prints them.

### Example output (first card)

```
Dear Yossi,
Best Greetings!
Eitan
********************************
```

Each of the other cards prints in the same format, with its own greeting line.

## Notes

- There are no automatic tests. The "tests" are the two `Main` methods that print the cards, and you check the output by eye.
- The written answers to the assignment questions are comments at the bottom of the `ManyCards` class.

## Author

Eitan
