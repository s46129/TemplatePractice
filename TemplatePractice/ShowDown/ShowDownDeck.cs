using System;
using System.Collections.Generic;

namespace TemplatePractice.ShowDown;

internal class ShowDownDeck : Deck
{
    public ShowDownDeck()
    {
        Cards = new List<Card>();

        foreach (ShowDownCard.Suits suit in Enum.GetValues(typeof(ShowDownCard.Suits)))
        {
            for (var i = 2; i < 14; i++)
            {
                var card = new ShowDownCard(suit, i);
                Cards.Add(card);
            }
        }
    }


    public override void Distribute(List<Player> players)
    {
        throw new System.NotImplementedException();
    }
}