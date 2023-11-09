using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]public class CreatureCard: BaseCard
{
    [SerializeField]private ParametersCard parametersCard;
    [SerializeField]private PropertyCard propertyCard;
    public CreatureCard(int id, string name, int manaCost, CardRarity rarity, ParametersCard parametersCard, PropertyCard propertyCard): base(id, name, manaCost, rarity)
    {
        this.parametersCard = parametersCard;
        this.propertyCard = propertyCard;
    }
    public CreatureCard(int id, string name, int manaCost, CardRarity rarity, int parametersCardId, int propertyCardId): base(id, name, manaCost, rarity)
    {
        this.parametersCard = (ParametersCard)CardCollection.GetCard(parametersCardId);
        this.propertyCard = (PropertyCard)CardCollection.GetCard(propertyCardId);
    }
    public CreatureCard(int id, string name, int manaCost, CardRarity rarity, int maxHealth, int attackDamage, List<ParametersType> parametersTypes, TriggerType triggerType, TargetType targetType, EffectType effectType, int effectValue): base(id, name, manaCost, rarity)
    {
        this.parametersCard = new ParametersCard(id, "", 0, rarity, maxHealth, attackDamage, parametersTypes);
        this.propertyCard = new PropertyCard(id, "", 0, rarity, triggerType, targetType, effectType, effectValue);
    }
    public CreatureCard(int id, string name, int manaCost, CardRarity rarity, string description, int maxHealth, int attackDamage, List<ParametersType> parametersTypes, TriggerType triggerType, TargetType targetType, EffectType effectType, int effectValue): base(id, name, manaCost, rarity, description)
    {
        this.parametersCard = new ParametersCard(id, "", 0, rarity, maxHealth, attackDamage, parametersTypes);
        this.propertyCard = new PropertyCard(id, "", 0, rarity, triggerType, targetType, effectType, effectValue);
    }
    public int GetManaCost()
    {
        return manaCost;
    }
    public int GetMaxHealth()
    {
        return parametersCard.GetMaxHealth();
    }
    public int GetHealth()
    {
        return parametersCard.GetCurrentHealth();
    }
    public int GetAttackDamage()
    {
        return parametersCard.GetAttackDamage();
    }
    public List<ParametersType> GetParameters()
    {
        return parametersCard.GetParameters();
    }
    public void Damage(int damageValue)
    {

    }
    public void Heal(int healValue)
    {

    }
    //public ParametersCard(int id, string name, CardRarity rarity, int maxHealth, int attackDamage, string parametersTypes): base(id, name, rarity)
}