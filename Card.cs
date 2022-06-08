class Card 
{
    // properties
    public string Name;
    public string Suit;
    public int Val;

    // constructor
    public Card (string suit, int val)
    {
        if (val == 1){
            Name = "Ace";
        }
        else if (val == 11)
        {
            Name = "Jack";
        }
        else if (val == 12){
            Name = "Queen";
        }
        else if (val == 13){
            Name = "King";
        }
        else {
            Name = val.ToString();
        }
        Suit = suit;
        Val = val;
    }

    // methods
    public void Print()
    {
        Console.WriteLine(this.Name);
        Console.WriteLine(this.Suit);
        Console.WriteLine(this.Val);
    }


}