using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplatePractice;

internal abstract class GameFlow
{
    protected readonly List<Player> Players = new List<Player>();
    protected Deck Deck;

    public virtual void Start()
    {
        AddPlayers();
        InitialDeck();
    }

    private void InitialDeck()
    {
        Deck = CreateDeck();
        Deck.Shuffle();
        Deck.Distribute(Players);
    }

    protected abstract Deck CreateDeck();

    private void AddPlayers()
    {
        for (int i = 0; i < 4; i++)
        {
            AddPlayer(i);
        }

        Console.WriteLine($"Start {GetType().Name}");
        Console.WriteLine("Players:\n" + string.Join("\n ", Players.Select(_ => _.Name)));
    }

    private void AddPlayer(int i)
    {
        Player player;
        while (true)
        {
            Console.WriteLine($"Add Player {i + 1} Type\n1. Human\n2. Computer");
            var value = Console.ReadLine();
            if (value == 1.ToString())
            {
                player = CreateHunamdPlayer();
                Console.WriteLine("Enter Player Name");
                player.NameHimSelf(Console.ReadLine());
            }
            else if (value == 2.ToString())
            {
                player = CreateComputerPlayer();
                player.NameHimSelf($"Computer {i}");
            }
            else
            {
                continue;
            }

            break;
        }

        Players.Add(player);
    }

    protected abstract Player CreateHunamdPlayer();

    protected abstract Player CreateComputerPlayer();


    protected virtual void End()
    {
    }
}