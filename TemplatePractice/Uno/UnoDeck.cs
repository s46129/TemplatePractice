using System;
using System.Collections.Generic;

namespace TemplatePractice.Uno;

internal class UnoDeck : Deck
{
    public UnoDeck()
    {
        Cards = new List<Card>();
        var colors = Enum.GetValues(typeof(UnoCard.Colors));
        foreach (var color in colors)
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
        for (var i = 0; i < 5; i++)
        {
            players.ForEach(_ => _.Hand.AddCard(DrawCard()));
        }
    }
}