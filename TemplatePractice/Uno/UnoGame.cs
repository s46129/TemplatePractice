using System;
using System.Collections.Generic;

namespace TemplatePractice.Uno;

internal class UnoGame : GameFlow
{
    private UnoCard _tableCard;
    private Player _winner;
    private List<Card> _unusedCards = new List<Card>();

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
            foreach (var player in Players)
            {
                var showCard = player.ShowCard();
                var hasValidCard = player.Hand._cards.Exists(_ => _.CompareTo(_tableCard) >= 0);
                if (hasValidCard)
                {
                    var valid = showCard.CompareTo(_tableCard);

                    if (valid < 0)
                    {
                        Console.WriteLine("Invalid card");
                        continue;
                    }

                    SetTableCard(showCard);
                }
                else
                {
                    if (Deck.Cards.Count == 0)
                    {
                        Deck.Cards = _unusedCards;
                        _unusedCards.Clear();
                    }

                    player.Hand.AddCard(Deck.DrawCard());
                }

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
        if (_tableCard != null)
        {
            _unusedCards.Add(_tableCard);
        }

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