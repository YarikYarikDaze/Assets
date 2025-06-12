using UnityEngine;
using System;
using System.Linq;


public class DeckScript : MonoBehaviour
{

    // red, yellow, blue
    [SerializeField]
    int[] CurrentNumberOfCards;

    [SerializeField]
    StarterDeck starterDeck;

    public void InitializeDeck(StarterDeck starterDeck)
    {
        this.starterDeck = starterDeck;
        this.Reshuffle();
    }

    public void Reshuffle()
    {
        // Set Current Number to Initial
        this.CurrentNumberOfCards = this.starterDeck.maxCards;
    }

    public ColorScript GiveCard()
    {
        int randomValue = (new System.Random()).Next(0, CurrentNumberOfCards.Sum());
        for (int i = 0; i < CurrentNumberOfCards.Length; i++)
        {
            randomValue -= CurrentNumberOfCards[i];
            if (randomValue < 0)
            {
                CurrentNumberOfCards[i]--;
                return starterDeck.colorScript[i];
            }
        }
        return null;
    }
}
