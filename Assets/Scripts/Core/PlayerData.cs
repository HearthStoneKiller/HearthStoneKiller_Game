using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField]private int id;
    [SerializeField]private string playerName;
    [SerializeField]private Dictionary<int, Deck> playerDecks;
    [SerializeField]private Dictionary<int, int> playerCardLibrary;
    [SerializeField]private int cardDust;
    // Start is called before the first frame update
    void Start()
    {
        this.id = 0;
        playerName = "Admin";
        playerDecks = new Dictionary<int, Deck>();
        playerCardLibrary = new Dictionary<int, int>();
        cardDust = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddDeck(Deck deck)
    {
        playerDecks.Add(playerDecks.Count, deck);
    }
    public void RemoveDeck(int deckId)
    {
        playerDecks.Remove(deckId);
    }
    public void RewriteDeck(int deckId, Deck deck)
    {
        playerDecks.Remove(deckId);
        playerDecks.Add(deckId, deck);
    }
    public void AddCard(int cardId)
    {
        if (playerCardLibrary.ContainsKey(cardId))
        {
            if (playerCardLibrary[cardId] == PlayerLibraryConstants.MaxNumberOfCardRepeats)
            {
                this.cardDust += (int)CardCollection.allCards[cardId].GetRarity();
            }
            else
            {
                playerCardLibrary[cardId] += 1;
            }
        }
        else
        {
            playerCardLibrary.Add(cardId, 1);
        }
    }
    public void RemoveCard(int cardId)
    {

    }
    public void ConvertCardToDust(int cardId)
    {
        if (playerCardLibrary.ContainsKey(cardId))
        {
            this.cardDust += (int)CardCollection.allCards[cardId].GetRarity() / 2;
            if (playerCardLibrary[cardId] == 1)
            {
                playerCardLibrary.Remove(cardId);
            }
            else
            {
                playerCardLibrary[cardId]--;
            }
        }
    }
    public void ConvertDustToCard(int cardId)
    {
        if (cardDust >= (int)CardCollection.allCards[cardId].GetRarity() && playerCardLibrary[cardId] < PlayerLibraryConstants.MaxNumberOfCardRepeats)
        {
            cardDust -= (int)CardCollection.allCards[cardId].GetRarity();
            playerCardLibrary[cardId]++;
        }
    }
}
