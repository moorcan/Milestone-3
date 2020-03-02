using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public PokerDeck deck = new PokerDeck();

    public void DrawFromTop()
    {
        Card card = deck.DrawFromTop();
        Debug.Log(card);
    }

    public void DrawFromBottom()
    {
        Card card = deck.DrawFromBottom();
        Debug.Log(card);
    }

    public void AddDeck()
    {
        PokerDeck anotherDeck = new PokerDeck();
        deck.Merge(anotherDeck);
        Debug.Log(deck.CardCount);
    }

    public void Shuffle()
    {
         deck.Shuffle();
        
    }
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
