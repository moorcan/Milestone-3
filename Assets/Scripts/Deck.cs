using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck 

{
   
    public int CardCount
    {
        get
        {
            if (Cards == null)
            {
                return 0;
            }
            else
            {
                return Cards.Count;
            }
        }
    }
    protected LinkedList<Card> Cards { get; set; }

    public Deck()
    {
        Cards = new LinkedList<Card>();
    }

    public void AddToTop(Card card)
    {
        Cards.AddLast(card);
    } 

    public void AddToBottom(Card card)
    {
        Cards.AddFirst(card);
    }
    public Card DrawFromTop()
    {
        Card topCard = Cards.Last();
        Cards.RemoveLast();
        return topCard;

    }

    public Card DrawFromBottom()
    {
        Card bottomCard = Cards.First();
        Cards.RemoveFirst();
        return bottomCard;
    }
    
    public void Shuffle()
    {
        List<Card> cards;
        cards = Cards.ToList();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            Card temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }

        Cards.Clear();
        foreach(Card c in cards)
        {
            Cards.AddFirst(c);
        }

    }

    public void Merge(Deck anotherDeck)
    {
        
        while(0 < anotherDeck.Cards.Count)
        {
            AddToTop(anotherDeck.DrawFromTop());
            
        }
       
        
    }


}
