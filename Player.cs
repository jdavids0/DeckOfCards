class Player 
{
    private string Name;
    private List<Card> hand = new List<Card>();

    public Player(string name){
        Name = name;
        hand = new List<Card>();
    }

    public Card Draw(Deck deck)
        {
            Card newCard = deck.Deal();
            hand.Add(newCard);
            return newCard;
        }

    public void PrintHand(){
        foreach(Card item in this.hand)
        {
            Console.WriteLine($"{item.Name} of {item.Suit}");
        }
    }

    public Card Discard(int i)
    {
        Card newCard;
        if (i < hand.Count)
        {
            newCard = hand[i];
            hand.RemoveAt(i);
            return newCard;
        }
        else {
            return null!;
        }
    }

}