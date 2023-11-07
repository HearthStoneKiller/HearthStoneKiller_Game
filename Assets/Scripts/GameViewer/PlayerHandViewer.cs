using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]public class PlayerHandViewer : MonoBehaviour
{
    [SerializeField]private Hand playerHand;
    [SerializeField]private GameObject creatureCard;
    [SerializeField]private GameObject spellCard;
    [SerializeField]private GameObject parametersCard;
    [SerializeField]private GameObject propertyCard;
    private List<GameObject> cards;
    void Start()
    {
        cards = new List<GameObject>();
        cards.Add(Instantiate(creatureCard, new Vector3(125, 0, 30), new Quaternion()));
        Debug.Log(playerHand.GetCount());
        for (int i = 0; i < playerHand.GetCount(); i++)
        {
            AddCard(playerHand.GetCard(i));
            Debug.LogWarning(cards[i].GetComponent<Card>().GetName());
        }
    }
    void Update()
    {
        
    }
    public void AddCard(Card card)
    {
        if (typeof(CreatureCard) == card.GetType())
        {
            cards.Add(Instantiate(creatureCard, new Vector3(125, 0, 30), new Quaternion()));
        }
        else if (typeof(SpellCard) == card.GetType())
        {
            cards.Add(Instantiate(spellCard, new Vector3(125, 0, 30), new Quaternion()));
        }
        else if (typeof(ParametersCard) == card.GetType())
        {
            cards.Add(Instantiate(parametersCard, new Vector3(125, 0, 30), new Quaternion()));
        }
        else if (typeof(PropertyCard) == card.GetType())
        {
            cards.Add(Instantiate(propertyCard, new Vector3(125, 0, 30), new Quaternion()));
        }
        else
        {
            cards.Add(Instantiate(propertyCard, new Vector3(125, 0, 30), new Quaternion()));
        }
    }
}
