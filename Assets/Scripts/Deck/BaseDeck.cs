using System;
using System.Collections.Generic;

public class BaseDeck : DeckCore
{
    private List<BaseCard> baseCards;
    public BaseDeck()
    {
        baseCards = new List<BaseCard>();
    }

    public override bool AddCard(Card card)
    {
        if (card.GetType() == typeof(BaseCard))
        {
            baseCards.Add((BaseCard)card);
            return true;
        }
        else
        {
            throw new Exception("Error! Imported object type is not BaseCard");
        }
    }

    public override bool RemoveCard(Card card)
    {
        if (card.GetType() == typeof(BaseCard))
        {
            baseCards.Remove((BaseCard)card);
            return true;
        }
        return false;
    }

    public override void Shuffle()
    {
        
    }
    public override void Clear()
    {
        baseCards = new List<BaseCard>();
    }
}
