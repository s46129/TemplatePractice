using System;
using System.Collections.Generic;

namespace TemplatePractice;

internal class Hand
{
    public readonly List<Card> _cards = new List<Card>();

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }

    public void PrintAllCards()
    {
        for (var index = 0; index < _cards.Count; index++)
        {
            var card = _cards[index];
            Console.WriteLine($"{index}. {card.ToString()}");
        }
    }
}