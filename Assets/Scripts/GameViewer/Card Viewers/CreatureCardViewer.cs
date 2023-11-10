using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]public class CreatureCardViewer : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject manaCost;
    [SerializeField] private GameObject health;
    [SerializeField] private GameObject attackDamage;
    [SerializeField] private GameObject parameters;
    [SerializeField] private GameObject parametersPrefab;
    [SerializeField] private List<GameObject> parametersGameObjects;
    [SerializeField] private CreatureCard creatureCard;

    // Sprites
    [SerializeField] private Sprite bleedingSprite;
    [SerializeField] private Sprite shieldSprite;
    [SerializeField] private Sprite deathTouchSprite;
    [SerializeField] private Sprite healingSprite;
    [SerializeField] private Sprite hz1Sprite;
    [SerializeField] private Sprite hz2Sprite;
    [SerializeField] private Sprite hz3Sprite;
    [SerializeField] private Sprite randomSprite;
    [SerializeField] private Sprite trapSprite;
    [SerializeField] private Sprite temporarySprite;
    [SerializeField] private Sprite doubleAttackSprite;
    [SerializeField] private Sprite massAttackSprite;
    //
    // Start is called before the first frame update
    void Start()
    {
        manaCost.GetComponent<TextMeshProUGUI>().text = creatureCard.GetManaCost().ToString();
        health.GetComponent<TextMeshProUGUI>().text = creatureCard.GetHealth().ToString();
        attackDamage.GetComponent<TextMeshProUGUI>().text = creatureCard.GetAttackDamage().ToString();
        for (int i = 0; i < creatureCard.GetParameters().Count; i++)
        {
            parametersPrefab.GetComponent<Image>().sprite = CalculateSprite(creatureCard.GetParameters()[i]);
            parametersGameObjects.Add(Instantiate(parametersPrefab, new Vector3(0,0,-1), this.transform.rotation));
            parametersGameObjects[i].transform.Rotate(90f, 0f, 180f);
            parametersGameObjects[i].transform.SetParent(parameters.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCreatureCard(int creatureCardId)
    {
        if (CardCollection.GetCard(creatureCardId).GetType() == typeof(CreatureCard))
        {
            this.creatureCard = (CreatureCard)CardCollection.GetCard(creatureCardId);
        }
        else
        {
            this.creatureCard = (CreatureCard)CardCollection.GetCard(0);
        }
    }
    public void SetCreatureCard(CreatureCard creatureCard)
    {
        this.creatureCard = creatureCard;
    }
    private Sprite CalculateSprite(ParametersType parameter)
    {
        Sprite result = bleedingSprite;
        switch (parameter)
        {
            case ParametersType.BLEEDING:
            result = bleedingSprite;
            break;

            case ParametersType.DEATH_TOUCH:
            result = deathTouchSprite;
            break;

            case ParametersType.DOUBLE_ATTACK:
            result = doubleAttackSprite;
            break;

            case ParametersType.HEALING:
            result = healingSprite;
            break;

            case ParametersType.HZ1:
            result = hz1Sprite;
            break;

            case ParametersType.HZ2:
            result = hz2Sprite;
            break;

            case ParametersType.HZ3:
            result = hz3Sprite;
            break;

            case ParametersType.MASS_ATTACK:
            result = massAttackSprite;
            break;

            case ParametersType.RANDOM:
            result = randomSprite;
            break;

            case ParametersType.SHIELD:
            result = shieldSprite;
            break;

            case ParametersType.TEMPORARY:
            result = temporarySprite;
            break;

            case ParametersType.TRAP:
            result = trapSprite;
            break;
        }
        return result;
    }
}
