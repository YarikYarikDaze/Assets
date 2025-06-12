using UnityEngine;



public class DeckScript : MonoBehaviour
{

    int[] CurrentNumberOfCards;

    public StarterDeck starterDeck;

    public void InitializeDeck()
    {
        this.Reshuffle();
    }

    public void Reshuffle()
    {
        // Set Current Number to Initial
        this.CurrentNumberOfCards = this.starterDeck.maxCards;
    }

    public ColorScript GiveCard()
    {
        // Create New Instancce Of A Card
        // Assign Collor
        // Give It To The Event Manager
    }
}
