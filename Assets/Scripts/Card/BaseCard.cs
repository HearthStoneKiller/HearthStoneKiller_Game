using System;
[Serializable]public class BaseCard: Card
{
    public BaseCard(int id, string name, int manaCost, CardRarity rarity): base(id, name, manaCost, rarity)
    {

    }
    public BaseCard(int id, string name, int manaCost, CardRarity rarity, string description): base(id, name, manaCost, rarity, description)
    {

    }
}
