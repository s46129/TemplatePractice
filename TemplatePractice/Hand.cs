using System.Collections.Generic;

namespace TemplatePractice;

internal class Hand
{
    public readonly List<Card> _cards = new List<Card>();

    public void AddCard(Card card)
    {
        _cards.Add(card);
    }
}