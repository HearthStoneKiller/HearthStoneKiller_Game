using System;
[Serializable]public class Card
{
    private string name;
    private string description;
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
}
