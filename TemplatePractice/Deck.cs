using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplatePractice;

internal abstract class Deck
{
    public List<Card> Cards =new List<Card>();
    
    public void Shuffle()
    {
        var random = new Random();
        Cards = Cards.OrderBy(_ => random.Next()).ToList();
    }

public Card DrawCard()
{
    var card = Cards.First();
    Cards.RemoveAt(0);
    return card;
}

    public abstract void Distribute(List<Player> players);
}