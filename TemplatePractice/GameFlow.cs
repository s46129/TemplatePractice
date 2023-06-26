using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplatePractice;

internal abstract class GameFlow
{
    private List<Player> _players = new List<Player>();

    public virtual void Start()
    {
        AddPlayers();

        Console.WriteLine($"Start {this.GetType().Name}");
        Console.WriteLine("Players:\n" + string.Join("\n ", _players.Select(_ => _.Name)));
    }

    private void AddPlayers()
    {
        for (int i = 0; i < 4; i++)
        {
            AddPlayer(i);
        }
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

        _players.Add(player);
    }

    protected abstract Player CreateHunamdPlayer();

    protected abstract Player CreateComputerPlayer();


    protected virtual void End()
    {
    }
}