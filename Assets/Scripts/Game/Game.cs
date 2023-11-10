using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]public class Game : MonoBehaviour
{
    [SerializeField]private GamePhase currentGamePhase;

    [SerializeField]private GameObject playerPrefab;
    [SerializeField]private GameObject firstPlayer;
    [SerializeField]private GameObject secondPlayer;

    [SerializeField]private GameObject gameViewerPrefab;
    [SerializeField]private GameObject gameViewer;

    [SerializeField]private int firstPlayerHealth;
    [SerializeField]Stack<Card> firstPlayerDeck;
    [SerializeField]private int secondPlayerHealth;
    [SerializeField]Stack<Card> secondPlayerDeck;

    [SerializeField]private Stack<int> stack;
    void Start()
    {
        // Инициируются игровые объекты на сцене
        firstPlayer = Instantiate(playerPrefab, new Vector3(0,0,0), new Quaternion());
        secondPlayer = Instantiate(playerPrefab, new Vector3(0,0,0), new Quaternion());

        gameViewer = Instantiate(gameViewerPrefab, new Vector3(0,0,0), new Quaternion());
        gameViewer.GetComponent<GameViewerManager>().SetPlayers(firstPlayer.GetComponent<Player>(),secondPlayer.GetComponent<Player>());
        //

        // Игрокам назначаются стартовые значения здоровья
        firstPlayerHealth = GameConstants.PlayerStartHealth;
        secondPlayerHealth = GameConstants.PlayerStartHealth;
        //

        //Запускается стартовая фаза игры
        currentGamePhase = GamePhase.START_GAME_PHASE;
        //

        firstPlayer.transform.GetChild(0).GetComponent<Deck>().AddCard(CardCollection.GetCard(1001));
        secondPlayer.transform.GetChild(0).GetComponent<Deck>().AddCard(CardCollection.GetCard(1001));

        firstPlayer.transform.GetChild(1).GetComponent<Hand>().AddCard(CardCollection.GetCard(1002));
        firstPlayer.transform.GetChild(1).GetComponent<Hand>().AddCard(CardCollection.GetCard(1007));

        secondPlayer.transform.GetChild(1).GetComponent<Hand>().AddCard(CardCollection.GetCard(1006));
        secondPlayer.transform.GetChild(1).GetComponent<Hand>().AddCard(CardCollection.GetCard(1007));
        secondPlayer.transform.GetChild(1).GetComponent<Hand>().AddCard(CardCollection.GetCard(1008));
        secondPlayer.transform.GetChild(1).GetComponent<Hand>().AddCard(CardCollection.GetCard(1009));
    }
    void Update()
    {
        
    }
    public void SuffleDeck(Stack<Card> deck)
    {

    }
    public void TakeCard()
    {

    }
    public void ChangeGamePhase()
    {
        switch (currentGamePhase)
        {
            case GamePhase.START_GAME_PHASE:

                currentGamePhase = GamePhase.START_STEP_PHASE;
                break;
            case GamePhase.START_STEP_PHASE:
                currentGamePhase = GamePhase.SPELL_STEP_PHASE_1;
                break;
            case GamePhase.SPELL_STEP_PHASE_1:
                currentGamePhase = GamePhase.BATTLE_STEP_PHASE;
                break;
            case GamePhase.BATTLE_STEP_PHASE:
                currentGamePhase = GamePhase.SPELL_STEP_PHASE_2;
                break;
            case GamePhase.SPELL_STEP_PHASE_2:
                currentGamePhase = GamePhase.END_STEP_PHASE;
                break;
            case GamePhase.END_STEP_PHASE:
                currentGamePhase = GamePhase.START_STEP_PHASE;
                break;
            case GamePhase.END_GAME_PHASE:
                break;
        }
    }
    public void SkipGamePhase()
    {
        
    }
    public void PlayStartGamePhase()
    {
        firstPlayer.transform.GetChild(0).GetComponent<Deck>().AddCard(CardCollection.GetCard(1));
    }
    public void PlayStartStepPhase()
    {

    }
    public void PlaySpellStepPhase()
    {

    }
    public void PlayBattleStepPhase()
    {

    }
    public void PlayEndGamePhase()
    {

    }
}
public enum GamePhase
{
    START_GAME_PHASE = 0,
    START_STEP_PHASE = 1,
    SPELL_STEP_PHASE_1 = 2,
    BATTLE_STEP_PHASE = 3,
    SPELL_STEP_PHASE_2 = 4,
    END_STEP_PHASE = 5,
    END_GAME_PHASE = 6
}
