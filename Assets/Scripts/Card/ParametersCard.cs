using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]public class ParametersCard: ModCard
{
    [SerializeField]private int maxHealth;
    private int currentHealth;
    private int attackDamage;
    private List<ParametersTypes> parametersTypes;
    public ParametersCard(string name, int maxHealth, int attackDamage, string parametersTypes): base(name)
    {
        this.maxHealth = maxHealth;
        this.currentHealth = maxHealth;
        this.attackDamage = attackDamage;
        this.parametersTypes = new List<ParametersTypes>();
        SetParametersTypes(parametersTypes);
    }
    private void SetParametersTypes(string parametersTypes)
    {
        string[] strings = parametersTypes.Split(new char[] {'/'});
        foreach (var str in strings)
        {
            switch (str)
            {
                case "NO_PARAMETER":
                break;
                case "POISON":
                    this.parametersTypes.Add(ParametersTypes.POISON);
                break;
                case "SHIELD":
                    this.parametersTypes.Add(ParametersTypes.SHIELD);
                break;
            }
        }
    }
}
