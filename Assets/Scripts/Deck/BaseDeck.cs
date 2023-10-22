using System;
using System.Collections.Generic;
using UnityEngine;
public class BaseDeck : MonoBehaviour
{
    [Header("Cards")]
    [SerializeField]private List<BaseCard> baseCards = new List<BaseCard>();
    public BaseDeck()
    {
        baseCards = new List<BaseCard>();
    }

    public bool AddCard(Card card)
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

    public bool RemoveCard(Card card)
    {
        if (card.GetType() == typeof(BaseCard))
        {
            baseCards.Remove((BaseCard)card);
            return true;
        }
        return false;
    }

    public void Shuffle()
    {
        
    }
    public void Clear()
    {
        baseCards = new List<BaseCard>();
    }
}
