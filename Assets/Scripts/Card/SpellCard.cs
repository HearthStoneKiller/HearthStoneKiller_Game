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

        /*if (spellCardTargetType == TargetType.YOUR_TARGET || spellCardTargetType == TargetType.NO_TARGET) // Заклинание срабатывает на разыгрывающего игрока
        {
            if(spellCardEffectType == EffectType.TAKE_CARD)
            {
                result += "Возьмите " + effectValue.ToString() + " карт";
                if (effectValue == 1)
                {
                    result += "у";
                }
                else if (effectValue >= 2 && effectValue <= 4)
                {
                    result += "ы";
                }
                return result;
            }
            if(spellCardEffectType == EffectType.HEAL_TARGET)
            {
                result += "Восполните " + effectValue.ToString() + " единиц здоровья";
                return result;
            }
        }
        switch (spellCardEffectType)
        {
            case EffectType.CAPTURE_TARGET:
                result += "Захватите вражеское существо на 1 ход";
                return result;
            case EffectType.CLONE_TARGET:
                result += "Скопируйте ";
                if (spellCardTargetType == TargetType.ENEMY_CARD_TARGET)
                {
                    result += "существо оппонента";
                }
                else if (spellCardTargetType == TargetType.YOUR_CARD_TARGET)
                {
                    result += "свое существо";
                }
                else if (spellCardTargetType == TargetType.ALL_CARD_TARGET)
                {
                    result += "любое существо на столе";
                }
                else
                {
                    result = "Error!";
                }
                return result;
            case EffectType.DAMAGE_TARGER:
                result += "Нанесите " + effectValue.ToString() + " единиц урона ";
                break;
            case EffectType.DESTROY_TARGET:
                result += "";
                break;
            case EffectType.HEAL_TARGET:
                result += "";
                break;
        }
        result = "Error!";
        return result;
        */
    }
}
