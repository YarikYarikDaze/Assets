using UnityEngine;
using System;

public class EventManagerScript : MonoBehaviour
{
    DeckScript deckScript;
    public StarterDeck starterDeck;

    [SerializeField]
    GameObject[] players;

    [SerializeField]
    GameObject CardPrefab;

    [SerializeField]
    int currentPlayerId;

    [SerializeField]
    int initialHandCardNumber = 8;

    [SerializeField]
    GameObject mainCamera;


    string[][] effects;

    void Start()
    {
        this.InitializeStarterDeck();
        this.InitializePlayers();
        this.InitializeCamera();
        this.InitializeEffects();
    }

    void InitializeCamera()
    {
        this.mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void InitializeEffects()
    {
        
    }
    void InitializePlayers()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        this.AsignFirstPlayer();
        for (int j = 0; j < 1; j++)
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

    int AsignFirstPlayer()
    {
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
        this.IncrementPlayerId();
        this.mainCamera.transform.Rotate(0, 0, 360 / this.players.Length);
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

    void CastSpell()
    {
        
    }
}
