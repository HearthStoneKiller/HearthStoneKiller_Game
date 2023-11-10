using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]public class PlayerScreenViewer : MonoBehaviour
{
    [SerializeField]private Player currentPlayer;
    [SerializeField]private Player enemyPlayer;
    [SerializeField]private PlayerHandViewer playerHandViewer;
    void Start()
    {
        playerHandViewer.SetPlayerHand(currentPlayer.GetHand());
    }
    void Update()
    {
        
    }
    public void SetCerrentPlayer(Player player)
    {
        this.currentPlayer = player;
    }
    public void SetEnemyPlayer(Player player)
    {
        this.enemyPlayer = player;
    }
    public void SetPlayers(Player currentPlayer, Player enemyPlayer)
    {
        this.currentPlayer = currentPlayer;
        this.enemyPlayer = enemyPlayer;
    }
}
