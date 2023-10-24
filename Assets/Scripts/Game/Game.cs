using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]public class Game : MonoBehaviour
{
    [SerializeField]private Player firstPlayer;
    [SerializeField]private Table firstPlayerTable;
    [SerializeField]private Player secondPlayer;
    [SerializeField]private Table secondPlayerTable;
    void Start()
    {
        firstPlayer.transform.GetChild(0).GetComponent<Deck>().AddCard(CardCollection.GetCard(1));
        firstPlayer.transform.GetChild(0).GetComponent<Deck>().AddCard(CardCollection.GetCard(51));
        firstPlayer.transform.GetChild(0).GetComponent<Deck>().AddCard(CardCollection.GetCard(101));
        firstPlayer.transform.GetChild(0).GetComponent<Deck>().AddCard(CardCollection.GetCard(151));

        secondPlayer.transform.GetChild(0).GetComponent<Deck>().AddCard(CardCollection.GetCard(1));
    }
    void Update()
    {
        
    }
}
