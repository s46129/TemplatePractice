using System;

namespace TemplatePractice;

internal class Player
{
    public string Name { get; private set; }

    public void NameHimSelf()
    {
        Name = Console.ReadLine();
    }
}