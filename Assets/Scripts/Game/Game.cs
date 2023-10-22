using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]public class Game : MonoBehaviour
{
    [SerializeField]private Player firstPlayer = new Player();
    [SerializeField]private Table firstPlayerTable = new Table();
    [SerializeField]private Player secondPlayer = new Player();
    [SerializeField]private Table secondPlayerTable = new Table();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
