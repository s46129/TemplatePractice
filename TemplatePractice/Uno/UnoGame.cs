using System;

namespace TemplatePractice.Uno;

internal class UnoGame : GameFlow
{
    private UnoCard tableCard;

    protected override Deck CreateDeck()
    {
        return new UnoDeck();
    }

    public override void Start()
    {
        base.Start();
        SetTableCard(Deck.DrawCard());
    }

    private void SetTableCard(Card card)
    {
        tableCard = card as UnoCard;
        Console.WriteLine($"table card is {tableCard}");
    }

    protected override Player CreateHunamdPlayer()
    {
        return new UnoHumanPlayer();
    }

    protected override Player CreateComputerPlayer()
    {
        return new UnoComputerPlayer();
    }
}