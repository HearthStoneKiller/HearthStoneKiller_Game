using System;
using UnityEngine;

[Serializable]public class CreatureCard: BaseCard
{
    [SerializeField]private ParametersCard parametersCard;
    private PropertyCard propertyCard;
    public CreatureCard(string name, ParametersCard parametersCard, PropertyCard propertyCard): base(name)
    {
        this.parametersCard = parametersCard;
        this.propertyCard = propertyCard;
    }
    public CreatureCard(string name, int maxHealth, int attackDamage, string parametersTypes): base(name)
    {
        this.parametersCard = new ParametersCard("", maxHealth, attackDamage, parametersTypes);
    }
}
