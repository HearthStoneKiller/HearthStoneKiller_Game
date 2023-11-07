using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]private string id;
    [SerializeField]private string playerName;
    [SerializeField]private List<Deck> playerDecks;
    [SerializeField]private Dictionary<int, int> playerLibrary;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
