using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]public class ModDeck : MonoBehaviour
{
    [Header("Cards")]
    [SerializeField]private List<ModCard> modCards = new List<ModCard>();
    public ModDeck()
    {
        modCards = new List<ModCard>();
    }

    public bool AddCard(Card card)
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

    public bool RemoveCard(Card card)
    {
        if (card.GetType() == typeof(ModCard))
        {
            modCards.Remove((ModCard)card);
            return true;
        }
        return false;
    }

    public void Shuffle()
    {

    }
    public void Clear()
    {
        modCards = new List<ModCard>();
    }
}
