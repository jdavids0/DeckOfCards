class Deck
{
    public List<Card> cards = new List<Card>();
    string[] DeckNames = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        
    string[] DeckSuits = {"Spades", "Hearts", "Clubs", "Diamonds"};
    
    int[] DeckVal = {1,2,3,4,5,6,7,8,9,10,11,12,13};
    
    public Deck (){

        // cards.Clear();

        foreach( string suit in DeckSuits)
        {
            foreach (int num in DeckVal)
            {
                Card newCard = new Card(suit, num);
                cards.Add(newCard);
                // Console.WriteLine($"{newCard.Name} of {newCard.Suit}");

            }

        }
    }

    public void CreateDeck()
    {
        foreach( string suit in DeckSuits)
        {
            foreach (int num in DeckVal)
            {
                Card newCard = new Card(suit, num);
                cards.Add(newCard);

            }

        }
    }

    public Card Deal()
    {
        Card removedCard = cards[cards.Count - 1];
        cards.RemoveAt(cards.Count - 1);
        // Console.WriteLine($"{removedCard.Name} of {removedCard.Suit}");
        return removedCard;
    }

    public void Reset()
    {
        cards = new List<Card>();
        CreateDeck();
    }

    public void Shuffle()
    {
        List<Card> unshuffled = cards;
        List<Card> shuffled = new List<Card>();
        Random rand = new Random();
        while(unshuffled.Count > 0){
            int i = rand.Next(0, unshuffled.Count);
            shuffled.Add(unshuffled[i]);
            unshuffled.RemoveAt(i);
        }
        this.cards = shuffled;
        
    }
}