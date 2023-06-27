using System;

namespace TemplatePractice.Uno;

internal class UnoGame : GameFlow
{
    private UnoCard _tableCard;
    private Player _winner;

    protected override Deck CreateDeck()
    {
        return new UnoDeck();
    }

    public override void Start()
    {
        base.Start();
        SetTableCard(Deck.DrawCard());
        GameLoop();
    }

    private void GameLoop()
    {
        do
        {
            foreach (var player in _players)
            {
                var showCard = player.ShowCard();
                var valid = showCard.CompareTo(_tableCard);
                if (valid < 0)
                {
                    Console.WriteLine("Invalid card");
                    continue;
                }

                SetTableCard(showCard);
                if (player.Hand._cards.Count == 0)
                {
                    _winner = player;
                    break;
                }
            }
        } while (_winner == null);

        Console.WriteLine($"Winner is {_winner.Name}");
    }

    private void SetTableCard(Card card)
    {
        _tableCard = card as UnoCard;
        Console.WriteLine($"table card is {_tableCard}");
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