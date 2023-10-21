public abstract class DeckCore
{
    public abstract bool AddCard(Card card);
    public abstract bool RemoveCard(Card card);
    public abstract void Shuffle();
    public abstract void Clear();
}
