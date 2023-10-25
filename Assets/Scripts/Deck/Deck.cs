using System;
using UnityEngine;
[Serializable]public class Deck : MonoBehaviour
{
    [SerializeField]private BaseDeck baseDeck;
    [SerializeField]private ModDeck modDeck;
    public void SetBaseDeck()
    {

    }
    public void SetModDeck()
    {

    }
    public void AddCard(Card newCard)
    {
        if ((newCard.GetType() == typeof(CreatureCard) || newCard.GetType() == typeof(SpellCard)) && IsItPossipleToAddCard(newCard))
        {
            baseDeck.AddCard(newCard);
        }
        else if ((newCard.GetType() == typeof(ParametersCard) || newCard.GetType() == typeof(PropertyCard)) && IsItPossipleToAddCard(newCard))
        {
            modDeck.AddCard(newCard);
        }
    }
    public void RemoveCard(Card removableCard)
    {
        if (removableCard.GetType() == typeof(BaseDeck))
        {
            baseDeck.RemoveCard(removableCard);
        }
        else if (removableCard.GetType() == typeof(ModDeck))
        {
            modDeck.RemoveCard(removableCard);
        }
    }
    public void RemoveBaseCard(BaseCard removableBaseCard)
    {
        baseDeck.RemoveCard(removableBaseCard);
    }
    public void RemoveModCard(ModCard removableModCard)
    {
        modDeck.RemoveCard(removableModCard);
    }
    public bool IsItPossipleToAddCard(Card potentialNewCard)
    {
        int countOfCards = 0;
        if (potentialNewCard.GetType() == typeof(CreatureCard) || potentialNewCard.GetType() == typeof(SpellCard))
        {
            if (baseDeck.GetCount() == DeckConstants.BaseDeckSize)
            {
                return false;
            }
            for (int i = 0; i < baseDeck.GetCount(); i++)
            {
                if (potentialNewCard.Equals(baseDeck.GetCard(i)))
                {
                    countOfCards++;
                }
            }
            if (countOfCards >= DeckConstants.MaxNumberOfBaseCardsRepeats)
            {
                return false;
            }
        }
        else if (potentialNewCard.GetType() == typeof(ParametersCard) || potentialNewCard.GetType() == typeof(PropertyCard))
        {
            if (modDeck.GetCount() == DeckConstants.ModDeckSize)
            {
                return false;
            }
            for (int i = 0; i < modDeck.GetCount(); i++)
            {
                if (potentialNewCard.Equals(modDeck.GetCard(i)))
                {
                    countOfCards++;
                }
            }
            if (countOfCards >= DeckConstants.MaxNumberOfModCardsRepeats)
            {
                return false;
            }
        }
        return true;
    }
}