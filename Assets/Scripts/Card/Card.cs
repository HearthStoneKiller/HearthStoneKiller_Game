using System;
using UnityEngine;
[Serializable]public class Card
{
    [SerializeField]protected string name;
    [SerializeField]protected string description;
    public Card(string name)
    {
        this.name = name;
        this.description = "";
    }
    public string GetName()
    {
        return name;
    }
    public string GetDescription()
    {
        return description;
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
