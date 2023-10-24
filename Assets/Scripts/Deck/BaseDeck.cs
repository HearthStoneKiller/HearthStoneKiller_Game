using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]public class BaseDeck : MonoBehaviour
{
    [Header("Cards")]
    [SerializeField]private List<BaseCard> baseCards = new List<BaseCard>();
    public BaseDeck()
    {
        baseCards = new List<BaseCard>();
    }
    public int GetCount()
    {
        return baseCards.Count;
    }
    public BaseCard GetCard(int index)
    {
        if (index < 0 || index >= baseCards.Count)
        {
            throw new IndexOutOfRangeException();
        }
        return baseCards[index];
    }
    public bool AddCard(Card card)
    {
        if (card.GetType() == typeof(CreatureCard))
        {
            baseCards.Add((CreatureCard)card);
            return true;
        }
        else if (card.GetType() == typeof(SpellCard))
        {
            baseCards.Add((SpellCard)card);
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
