using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]public class Player : MonoBehaviour
{
    [SerializeField]private string id;
    [SerializeField]private string playerName;
    [SerializeField]private Deck deck;
    [SerializeField]private Hand hand;
    [SerializeField]private Table table;
    void Start()
    {
        
    }
    void Update()
    {

    }
}
