using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]public class Hand : MonoBehaviour
{
    private List<Card> cards = new List<Card>();
    private void Start() 
    {
        
    }
    private void Update()
    {
        
    }
    public int GetCount()
    {
        return cards.Count;
    }
    public Card GetCard(int index)
    {
        if (index < 0 || index >= cards.Count)
        {
            throw new IndexOutOfRangeException();
        }
        return cards[index];
    }
    public void AddCard(Card card)
    {
        if (IsHandFool())
        {
            throw new Exception("Hand is full");
        }
        cards.Add(card);
    }
    public void RemoveCard(int cardPosition)
    {
        cards.RemoveAt(cardPosition);
    }
    public void SwapCards(int firstCardPosition, int secondCardPosition)
    {
        Card card = cards[firstCardPosition];
        cards[firstCardPosition] = cards[secondCardPosition];
        cards[secondCardPosition] = card;
    }
    public void TransposeCard(int oldPosition, int newPosition)
    {
        Card card = cards[oldPosition];
        cards.RemoveAt(oldPosition);
        cards.Insert(newPosition, card);
    }
    public bool IsHandFool()
    {
        return cards.Count >= GameConstants.MaxNumberOfCardsInHand;
    }
}