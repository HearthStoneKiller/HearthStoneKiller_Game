using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]public class ParametersCard: ModCard
{
    [SerializeField]private int maxHealth;
    private int currentHealth;
    private int attackDamage;
    private List<ParametersType> parametersTypes;
    public ParametersCard(int id, string name, int manaCost, CardRarity rarity, int maxHealth, int attackDamage, List<ParametersType> parametersTypes): base(id, name, manaCost, rarity)
    {
        this.maxHealth = maxHealth;
        this.currentHealth = maxHealth;
        this.attackDamage = attackDamage;
        this.parametersTypes = parametersTypes;
    }
    public ParametersCard(int id, string name, int manaCost, CardRarity rarity, string description, int maxHealth, int attackDamage, List<ParametersType> parametersTypes): base(id, name, manaCost, rarity, description)
    {
        this.maxHealth = maxHealth;
        this.currentHealth = maxHealth;
        this.attackDamage = attackDamage;
        this.parametersTypes = parametersTypes;
    }
    public int GetMaxHealth()
    {
        return maxHealth;
    }
    public int GetCurrentHealth()
    {
        return currentHealth;
    }
    public int GetAttackDamage()
    {
        return attackDamage;
    }
    public List<ParametersType> GetParameters()
    {
        return parametersTypes;
    }
}
