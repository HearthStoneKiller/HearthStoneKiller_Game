using System;
[Serializable]public class ModCard: Card
{
    public ModCard(int id, string name, int manaCost, CardRarity rarity): base(id, name, manaCost, rarity)
    {

    }
    public ModCard(int id, string name, int manaCost, CardRarity rarity, string description): base(id, name, manaCost, rarity, description)
    {

    }
}
