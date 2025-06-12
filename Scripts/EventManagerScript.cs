using UnityEngine;

public class EventManagerScript : MonoBehaviour
{
    DeckScript deckScript;
    public StarterDeck starterDeck;

    [SerializeField]
    GameObject [] players;

    [SerializeField]
    GameObject CardPrefab;

    int currentPlayerId;

    void Start()
    {
        this.InitializeStarterDeck();
        deckScript.InitializeDeck(starterDeck);
        this.InitializePlayers();
        this.GiveCard();
    }

    void InitializePlayers() {
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    void InitializeStarterDeck() {
        deckScript = GameObject.FindWithTag("Deck").GetComponent<DeckScript>();
    }

    void giveTurn()
    {
        
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
