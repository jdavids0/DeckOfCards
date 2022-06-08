// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Card Lemmy = new Card ("Spades", 1);

Console.WriteLine($"It's the {Lemmy.Name} of {Lemmy.Suit}! The #{Lemmy.Val} card!");

Deck deck = new Deck ();

Player Tex = new Player ("Tex");

deck.Deal();
deck.Reset();
deck.Deal();
deck.Shuffle();

Tex.Draw(deck);
Tex.Draw(deck);
Tex.Draw(deck);
Tex.PrintHand();
Tex.Discard(2);
Tex.PrintHand();