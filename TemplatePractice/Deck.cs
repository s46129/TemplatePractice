using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplatePractice;

internal abstract class Deck
{
    protected List<Card> Cards;

    public void Shuffle()
    {
        var random = new Random();
        Cards = Cards.OrderBy(_ => random.Next()).ToList();
    }

    public Card DrawCard()
    {
        var card = Cards[0];
        Cards.Remove(card);
        return card;
    }

    public abstract void Distribute(List<Player> players);
}