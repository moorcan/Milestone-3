﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerCard : Card
{

    public override string  ToString()
    {

        string returnVal = Value.ToString() + " of " + Suit;
        return returnVal;
    }
    // Start is called before the first frame update

    public string Suit { get; set; }

    public int Value { get; set; }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
