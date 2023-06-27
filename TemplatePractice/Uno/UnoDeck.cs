﻿using System;
using System.Collections.Generic;

namespace TemplatePractice.Uno;

internal class UnoDeck : Deck
{
    public UnoDeck()
    {
        Cards = new List<Card>();
        foreach (var color in Enum.GetValues(typeof(UnoCard.Colors)))
        {
            for (var i = 0; i < 9; i++)
            {
                var unoCard = new UnoCard((UnoCard.Colors)color, i);
                Cards.Add(unoCard);
            }
        }
    }


    public override void Distribute(List<Player> players)
    {
    }
}