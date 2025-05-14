using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CardStack : MonoBehaviour
{
    List<int> cards;

    public bool isGameDeck;

    public bool HashCards
    {
        get
        {
            return cards != null && cards.Count > 0;
        }
    }

    public IEnumerable<int> GetCards()
    {
        /*if (cards == null)
        {
            yield break;
        }*/

        foreach (int i in cards)
        {
            yield return i;
        }
    }

    public int Pop()
    {
        int temp = cards[0];
        cards.Remove(0);
        return temp;
    }

    public void Push(int card)
    {
        cards.Add(card);
    }

    public void CreateDeck()
    {
        cards.Clear();

        for (int i = 0; i < 52; i ++)
        {
            cards.Add(i);
        } 

        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            int temporal = cards[k];
            cards[k] = cards[n];
            cards[n] = temporal;
        }
    }
    void Awake()
    {
        cards = new List<int>();

        if (isGameDeck)
        {
            CreateDeck();
        }
    }

}
