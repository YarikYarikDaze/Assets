using UnityEngine;

public class DeckScript : MonoBehaviour
{
    int InitialNumebrOfBlueCards, InitialNumebrOfRedCards, InitialNumebrOfYellowCards, InitialNumberOfCards;

    int CurrentNumebrOfBlueCards, CurrentNumebrOfRedCards, CurrentNumebrOfYellowCards, CurrentNumebrOfCards;
    void Start()
    {
        // Pull Number of Cards from External File
        this.Reshuffle();
    }

    public void Reshuffle()
    {
        // Set Current Number to Initial
        this.CurrentNumebrOfBlueCards = this.InitialNumberOfCards;
        this.CurrentNumebrOfRedCards = this.InitialNumebrOfRedCards;
        this.CurrentNumebrOfYellowCards = this.InitialNumebrOfYellowCards;
        this.CurrentNumebrOfCards = this.InitialNumberOfCards;
    }

    public void GiveCard()
    {
        // Create New Instancce Of A Card
        // Assign Collor
        // Give It To The Event Manager
    }
}
