using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplatePractice;

internal abstract class Deck
{
    protected List<Card> Cards;

    public void Shuffle()
    {
        Console.WriteLine("-------Default------");
        var random = new Random();
        Console.Write(string.Join(",", Cards.Select(_ => _.ToString())));
        Cards = Cards.OrderBy(_ => random.Next()).ToList();
        Console.WriteLine("-------Shuffled------");
        Console.Write(string.Join(",", Cards.Select(_ => _.ToString())));
    }

    public abstract void Distribute(List<Player> players);
}