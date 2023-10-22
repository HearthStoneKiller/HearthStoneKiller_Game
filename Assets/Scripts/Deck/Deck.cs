using System;
using UnityEngine;
[Serializable]public class Deck : MonoBehaviour
{
    [SerializeField]private BaseDeck baseDeck = new BaseDeck();
    [SerializeField]private ModDeck modDeck = new ModDeck();
}
