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
    public int GetCount()
    {
        return modCards.Count;
    }
    public ModCard GetCard(int index)
    {
        if (index < 0 || index >= modCards.Count)
        {
            throw new IndexOutOfRangeException();
        }
        return modCards[index];
    }
    public bool AddCard(Card card)
    {
        if (card.GetType() == typeof(ParametersCard))
        {
            modCards.Add((ParametersCard)card);
            return true;
        }
        else if (card.GetType() == typeof(PropertyCard))
        {
            modCards.Add((PropertyCard)card);
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
