using UnityEngine;

public class EventManagerScript : MonoBehaviour
{
    DeckScript deckScript;
    public StarterDeck starterDeck;

    [SerializeField]
    GameObject [] players;

    void Start()
    {
        this.InitializeStarterDeck();
        deckScript.InitializeDeck(starterDeck);
        this.InitializePlayers();
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
        deckScript.GiveCard();
    }
}
