using System;
using UnityEngine;
[Serializable]public class SpellCard: BaseCard
{
    [SerializeField]private TargetType spellCardTargetType;
    [SerializeField]private EffectType spellCardEffectType;
    [SerializeField]private int effectValue;
    [SerializeField]private string spellEffectDescription;
    public SpellCard(int id, string name, int manaCost, CardRarity rarity, TargetType spellCardTargetType, EffectType spellCardEffectType, int effectValue): base(id, name, manaCost, rarity)
    {
        this.spellCardTargetType = spellCardTargetType;
        this.spellCardEffectType = spellCardEffectType;
        this.effectValue = effectValue;
    }
    public SpellCard(int id, string name, int manaCost, CardRarity rarity, string description, TargetType spellCardTargetType, EffectType spellCardEffectType, int effectValue): base(id, name, manaCost, rarity, description)
    {
        this.spellCardTargetType = spellCardTargetType;
        this.spellCardEffectType = spellCardEffectType;
        this.effectValue = effectValue;
    }
    public SpellCard(int id, string name, int manaCost, CardRarity rarity, TargetType spellCardTargetType, EffectType spellCardEffectType, int effectValue, string spellEffectDescription): base(id, name, manaCost, rarity)
    {
        this.spellCardTargetType = spellCardTargetType;
        this.spellCardEffectType = spellCardEffectType;
        this.effectValue = effectValue;
        this.spellEffectDescription = spellEffectDescription;
    }
    public SpellCard(int id, string name, int manaCost, CardRarity rarity, string description, TargetType spellCardTargetType, EffectType spellCardEffectType, int effectValue, string spellEffectDescription): base(id, name, manaCost, rarity, description)
    {
        this.spellCardTargetType = spellCardTargetType;
        this.spellCardEffectType = spellCardEffectType;
        this.effectValue = effectValue;
        this.spellEffectDescription = spellEffectDescription;
    }
    public void ToString()
    {
        string targetString = "";
        string effectString = "";

        switch (spellCardTargetType)
        {
            case TargetType.ALL_CARD_TARGET:
                targetString = "";
                break;
            case TargetType.ALLENEMY_CARD_TARGET:
                targetString = "";
                break;
            case TargetType.ALLYOUR_CARD_TARGET:
                targetString = "";
                break;
            case TargetType.ENEMY_CARD_TARGET:
                targetString = "";
                break;
            case TargetType.ENEMY_TARGET:
                targetString = "";
                break;
            case TargetType.NO_TARGET:
                targetString = "";
                break;
            case TargetType.YOUR_CARD_TARGET:
                targetString = "";
                break;
            case TargetType.YOUR_TARGET:
                targetString = "";
                break;
        }
        switch (spellCardEffectType)
        {
            case EffectType.CAPTURE_TARGET:
                effectString = "Захватите существо оппонента на 1 ход";
                break;
            case EffectType.CLONE_TARGET:
                effectString = "Возьмите " + effectValue.ToString() + "карт";
                break;
            case EffectType.DAMAGE_TARGER:
                effectString = "Нанесите " + effectValue.ToString() + " единиц урона";
                break;
            case EffectType.DESTROY_TARGET:
                effectString = "Уничтожьте ";
                break;
            case EffectType.HEAL_TARGET:
                effectString = "Восстановите " + effectValue.ToString() + " единиц здоровья";
                break;
            case EffectType.NO_EFFECT:
                effectString = "";
                break;
            case EffectType.TAKE_CARD:
                effectString = "Возьмите " + effectValue.ToString() + "карт";
                break;
        }
    }
}
