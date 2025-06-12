using UnityEngine;
using System;

public class EventManagerScript : MonoBehaviour
{
    DeckScript deckScript;
    public StarterDeck starterDeck;

    [SerializeField]
    GameObject [] players;

    [SerializeField]
    GameObject CardPrefab;

    [SerializeField]
    int currentPlayerId;

    [SerializeField]
    int initialHandCardNumber = 8;

    [SerializeField]
    GameObject mainCamera;

    void Start()
    {
        this.InitializeStarterDeck();
        this.InitializePlayers();
        this.InitializeCamera();
    }

    void InitializeCamera()
    {
        this.camera = GameObject.FindGameObjectsWithTag("MainCamera");
    }
    void InitializePlayers()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        this.assignFirstPlayer();
        for(int j = 0; j<1; j++)
        {
            for (int i = 0; i < initialHandCardNumber; i++)
            {
                this.GiveCard();
            }
        }
    }

    void IncrementPlayerId()
    {
        currentPlayerId = (currentPlayerId++) % players.Length;
    }

    int AsignFirstPlayer() {
        currentPlayerId = (new System.Random()).Next(0, players.Length);
        return currentPlayerId;
    }

    void InitializeStarterDeck()
    {
        deckScript = GameObject.FindWithTag("Deck").GetComponent<DeckScript>();
        deckScript.InitializeDeck(starterDeck);
    }

    public void TurnEnded()
    {
        this.ChangeTurn();
    }
    void ChangeTurn()
    {
        this.incrementPlayerId();
        //players[currentPlayerId].takeTurn();
    }

    void GiveCard()
    {
        GameObject newCard = Instantiate(CardPrefab);
        newCard.GetComponent<CardScript>().color = deckScript.GiveCard();
        foreach (Transform child in players[currentPlayerId].transform)
          {
            if (child.tag == "Hand")
                newCard.transform.parent = child;
          }
    }
}
