using System;
using System.Collections.Generic;
using UnityEngine;

public static class CardCollection
{
    public static Dictionary<int, Card> allCards = new Dictionary<int, Card>()
    {
        {0, new Card("ZeroCard")},

        {1, new CreatureCard("Hero", 0, 0, "NO_PARAMETER")},

        {51, new SpellCard("Human")},

        {101, new ParametersCard("FireBall", 0, 0, "POISON")},

        {151, new PropertyCard("KillCode")}
    };
    public static Dictionary<int, Card> GetAllCards()
    {
        return allCards;
    }
    public static Card GetCard(int id)
    {
        try
        {
            return allCards[id];
        }
        catch
        {
            throw new IndexOutOfRangeException();
        }
    }
    public static int GetIdWithName(string name)
    {
        foreach (var element in allCards)
        {
            if (element.Value.GetName() == name)
            {
                return element.Key;
            }
        }
        throw new Exception("Find error");
    }
}
