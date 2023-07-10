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
            Console.WriteLine("Input cannot be null.");
            return ShowCard();
        }
        var tryParse = int.TryParse(selectKey, out var parse);
        if (!tryParse)
        {
            Console.WriteLine("Invalid Input");
            return ShowCard();
        }

        if (parse < 0 || parse > Hand._cards.Count)
        {
            Console.WriteLine("Input out of range.");
            return ShowCard();
        }

        var card = Hand._cards[parse];
        Hand._cards.Remove(card);
        return card;
    }
}