using System;
using System.Collections.Generic;

public class ModDeck : DeckCore
{
    private List<ModCard> modCards;
    public ModDeck()
    {
        modCards = new List<ModCard>();
    }

    public override bool AddCard(Card card)
    {
        if (card.GetType() == typeof(ModCard))
        {
            modCards.Add((ModCard)card);
            return true;
        }
        else
        {
            throw new Exception("Error! Imported object type is not ModCard");
        }
    }

    public override bool RemoveCard(Card card)
    {
        if (card.GetType() == typeof(ModCard))
        {
            modCards.Remove((ModCard)card);
            return true;
        }
        return false;
    }

    public override void Shuffle()
    {

    }
    public override void Clear()
    {
        modCards = new List<ModCard>();
    }
}
