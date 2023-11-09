using System;
using System.Collections.Generic;
using UnityEngine;

public static class CardCollection
{
    public static Dictionary<int, Card> allCards = new Dictionary<int, Card>()
    {
        {0, new Card(0, "ZeroCard", 0, CardRarity.COMMON)},

        //{id, new CreatureCard(int id, string name, int manaCost, CardRarity rarity, int maxHealth, int attackDamage, List<ParametersType> parametersTypes, TriggerType triggerType, TargetType targetType, EffectType effectType, int effectValue)}
        {1001, new CreatureCard(1001, "Human", 2, CardRarity.COMMON, 6, 5, new List<ParametersType>() {}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},
        {1002, new CreatureCard(1002, "Beast", 3, CardRarity.COMMON, 6, 5, new List<ParametersType>() {ParametersType.BLEEDING}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},
        {1003, new CreatureCard(1003, "Demon", 4, CardRarity.COMMON, 6, 5, new List<ParametersType>() {}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},
        {1004, new CreatureCard(1004, "Angel", 5, CardRarity.COMMON, 6, 5, new List<ParametersType>() {}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},
        {1005, new CreatureCard(1005, "Cat", 2, CardRarity.COMMON, 6, 5, new List<ParametersType>() {}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},
        {1006, new CreatureCard(1006, "Zombie", 3, CardRarity.COMMON, 6, 5, new List<ParametersType>() {}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},
        {1007, new CreatureCard(1007, "Dragon", 5, CardRarity.LEGENDARY, 6, 5, new List<ParametersType>() {ParametersType.MASS_ATTACK, ParametersType.TEMPORARY}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},
        {1008, new CreatureCard(1008, "Bear", 4, CardRarity.COMMON, 6, 5, new List<ParametersType>() {}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},
        {1009, new CreatureCard(1009, "Snake", 3, CardRarity.COMMON, 6, 5, new List<ParametersType>() {}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},
        {1010, new CreatureCard(1010, "Rat", 1, CardRarity.COMMON, 6, 5, new List<ParametersType>() {}, TriggerType.NO_TRIGGER, TargetType.NO_TARGET, EffectType.NO_EFFECT, 0)},

        //{id, new SpellCard(int id, string name, int manaCost, CardRarity rarity, TargetType spellCardTargetType, EffectType spellCardEffectType, int effectValue)}
        {2001, new SpellCard(2001, "Fire Ball", 2, CardRarity.COMMON, TargetType.ENEMY_CARD_TARGET, EffectType.DAMAGE_TARGER, 3)},
        {2002, new SpellCard(2002, "Fire Wall", 5, CardRarity.COMMON, TargetType.ALLENEMY_CARD_TARGET, EffectType.DAMAGE_TARGER, 3)},
        {2003, new SpellCard(2003, "Thunder", 7, CardRarity.COMMON, TargetType.ALL_CARD_TARGET, EffectType.DAMAGE_TARGER, 3)},
        {2004, new SpellCard(2004, "Lightninh", 3, CardRarity.COMMON, TargetType.ENEMY_CARD_TARGET, EffectType.DAMAGE_TARGER, 5)},
        {2005, new SpellCard(2005, "Sun Strike", 0, CardRarity.COMMON, TargetType.ENEMY_CARD_TARGET, EffectType.DAMAGE_TARGER, 3)},
        {2006, new SpellCard(2006, "Instant Death", 0, CardRarity.EPIC, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {2007, new SpellCard(2007, "Weakening", 0, CardRarity.COMMON, TargetType.ENEMY_CARD_TARGET, EffectType.DAMAGE_TARGER, 3)},
        {2008, new SpellCard(2008, "Sun Strike", 0, CardRarity.COMMON, TargetType.ENEMY_CARD_TARGET, EffectType.DAMAGE_TARGER, 3)},
        {2009, new SpellCard(2009, "Instant Death", 0, CardRarity.EPIC, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {2010, new SpellCard(2010, "Weakening", 0, CardRarity.COMMON, TargetType.ENEMY_CARD_TARGET, EffectType.DAMAGE_TARGER, 3)},

        //{id, new ParametersCard(int id, string name, int manaCost, CardRarity rarity, int maxHealth, int attackDamage, List<ParametersType> parametersTypes)}
        {3001, new ParametersCard(3001, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {ParametersType.BLEEDING})},
        {3002, new ParametersCard(3002, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {})},
        {3003, new ParametersCard(3003, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {})},
        {3004, new ParametersCard(3004, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {})},
        {3005, new ParametersCard(3005, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {})},
        {3006, new ParametersCard(3006, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {})},
        {3007, new ParametersCard(3007, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {})},
        {3008, new ParametersCard(3008, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {})},
        {3009, new ParametersCard(3009, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {})},
        {3010, new ParametersCard(3010, "Fire Hand", 2, CardRarity.COMMON, 4, 3, new List<ParametersType>() {})},

        //{id, new PropertyCard(int id, string name, int manaCost, CardRarity rarity, TriggerType triggerType, TargetType targetType, EffectType effectType, int effectValue)}
        {4001, new PropertyCard(4001, "KillCode", 4, CardRarity.COMMON, TriggerType.NO_TRIGGER, TargetType.ALL_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {4002, new PropertyCard(4002, "KillCode", 4, CardRarity.COMMON, TriggerType.WHEN_PLAYED, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {4003, new PropertyCard(4003, "KillCode", 4, CardRarity.COMMON, TriggerType.WHEN_PLAYED, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {4004, new PropertyCard(4004, "KillCode", 4, CardRarity.COMMON, TriggerType.WHEN_PLAYED, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {4005, new PropertyCard(4005, "KillCode", 4, CardRarity.COMMON, TriggerType.WHEN_PLAYED, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {4006, new PropertyCard(4006, "KillCode", 4, CardRarity.COMMON, TriggerType.WHEN_PLAYED, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {4007, new PropertyCard(4007, "KillCode", 4, CardRarity.COMMON, TriggerType.WHEN_PLAYED, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {4008, new PropertyCard(4008, "KillCode", 4, CardRarity.COMMON, TriggerType.WHEN_PLAYED, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {4009, new PropertyCard(4009, "KillCode", 4, CardRarity.COMMON, TriggerType.WHEN_PLAYED, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
        {4010, new PropertyCard(4010, "KillCode", 4, CardRarity.COMMON, TriggerType.WHEN_PLAYED, TargetType.ENEMY_CARD_TARGET, EffectType.DESTROY_TARGET, 0)},
    };
    public static Dictionary<int, Card> GetAllCards()
    {
        return allCards;
    }
    public static Card GetCard(int id)
    {
        try
        {
            return allCards[id];
        }
        catch
        {
            throw new IndexOutOfRangeException();
        }
    }
    public static int GetIdWithName(string name)
    {
        foreach (var element in allCards)
        {
            if (element.Value.GetName() == name)
            {
                return element.Key;
            }
        }
        throw new Exception("Find error");
    }
}
