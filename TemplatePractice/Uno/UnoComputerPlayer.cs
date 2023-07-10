using System;

namespace TemplatePractice.Uno;

internal class UnoComputerPlayer : Player
{
    private static readonly Random Random = new Random();

    public override Card ShowCard()
    {
        // AI 隨機選一張牌出
        var parse = Random.Next(0, Hand._cards.Count);
        return Hand._cards[parse];
    }
}