using System;

namespace TemplatePractice.ShowDown;

public class ShowDownCard : Card
{
    private readonly Suits _suit;
    private readonly int _rank;

    public ShowDownCard(Suits suit, int rank)
    {
        _suit = suit;
        _rank = rank;
    }

    public override int CompareTo(Card other)
    {
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        return $"{_rank} of {_suit}";
    }

    public enum Suits
    {
        Club,
        Diamond,
        Heart,
        Spade
    }
}