using System;
using UnityEngine;

[Serializable]public class PropertyCard: ModCard
{
    [SerializeField]private TriggerType triggerType;
    [SerializeField]private TargetType targetType;
    [SerializeField]private EffectType effectType;
    [SerializeField]private int effectValue;
    public PropertyCard(int id, string name, int manaCost, CardRarity rarity, TriggerType triggerType, TargetType targetType, EffectType effectType, int effectValue): base(id, name, manaCost, rarity)
    {
        this.triggerType = triggerType;
        this.targetType = targetType;
        this.effectType = effectType;
        this.effectValue = effectValue;
    }
    public PropertyCard(int id, string name, int manaCost, CardRarity rarity, string description, TriggerType triggerType, TargetType targetType, EffectType effectType, int effectValue): base(id, name, manaCost, rarity, description)
    {
        this.triggerType = triggerType;
        this.targetType = targetType;
        this.effectType = effectType;
        this.effectValue = effectValue;
    }
}
