public class Deck
{
    protected BaseDeck baseDeck;
    protected ModDeck modDeck;
    public Deck()
    {
        baseDeck = new BaseDeck();
        modDeck = new ModDeck();
    }
}
