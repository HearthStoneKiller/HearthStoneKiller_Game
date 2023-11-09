using System;
using UnityEngine;
[Serializable]public class Card
{
    [SerializeField]protected int id;
    [SerializeField]protected string name;
    [SerializeField]protected int manaCost;
    [SerializeField]protected string description;
    [SerializeField]protected CardRarity rarity;
    public Card(int id, string name, int manaCost, CardRarity rarity)
    {
        this.id = id;
        this.name = name;
        this.manaCost = manaCost;
        this.description = "";
        this.rarity = rarity;
    }
    public Card(int id, string name, int manaCost, CardRarity rarity, string description)
    {
        this.id = id;
        this.name = name;
        this.manaCost = manaCost;
        this.description = description;
        this.rarity = rarity;
    }

    public int GetId()
    {
        return id;
    }
    public string GetName()
    {
        return name;
    }
    public string GetDescription()
    {
        return description;
    }
    public CardRarity GetRarity()
    {
        return rarity;
    }
    public bool Equals(Card card)
    {
        if (card == null)
        {
            return false;
        }
        if (this.name == card.GetName())
        {
            return true;
        }
        return false;
    }
}
