using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]public class GameViewerManager : MonoBehaviour
{
    [SerializeField]private Player firstPlayer;
    [SerializeField]private PlayerScreenViewer firstPlayerScreenViewer;
    [SerializeField]private Player secondPlayer;
    [SerializeField]private PlayerScreenViewer secondPlayerScreenViewer;
    [SerializeField]private GameObject creatureCard;
    [SerializeField]private GameObject spellCard;
    [SerializeField]private GameObject parametersCard;
    [SerializeField]private GameObject propertyCard;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
