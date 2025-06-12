using UnityEngine;
using System;


public class DeckScript : MonoBehaviour
{

    // red, yellow, blue

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
        int randomValue = (new Random()).Next(0, CurrentNumberOfCards.Sum());
        for (int i = 0; i < CurrentNumberOfCards.Length; i++)
        {
            randomValue -= CurrentNumberOfCards[i];
            if (randomValue < 0)
            {
                return starterDeck.colorScript[i];
            }
        }
        return null;
    }
}
