using System;

namespace TemplatePractice.Uno;

internal class UnoHumanPlayer : Player
{
    public override Card ShowCard()
    {
        Console.WriteLine("Select a card to play");
        for (var index = 0; index < Hand._cards.Count; index++)
        {
            var _ = Hand._cards[index];
            Console.WriteLine($"{index}. {_.ToString()}\n");
        }

        var selectKey = Console.ReadLine();
        if (selectKey == null)
        {
            Console.WriteLine("Invalid Input");
            return ShowCard();
        }

        var parse = int.Parse(selectKey);
        if (parse < 0 || parse > Hand._cards.Count)
        {
            Console.WriteLine("Invalid Input");
            return ShowCard();
        }

        var card = Hand._cards[parse];
        Hand._cards.Remove(card);
        return card;
    }
}