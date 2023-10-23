using System;
using System.Collections.Generic;
using UnityEngine;

public class CardCollection : MonoBehaviour
{
    private Dictionary<int, Card> allCards = new Dictionary<int, Card>();
    private void Start()
    {
        allCards.Add(0, new Card("ZeroCard"));
        allCards.Add(1, new CreatureCard("Snake", 1, 2));
        allCards.Add(2, new CreatureCard("Human", 2, 2));
        allCards.Add(3, new CreatureCard("Bird", 1, 1));
    }
    public Dictionary<int, Card> GetAllCards()
    {
        return allCards;
    }
}
