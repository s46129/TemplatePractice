using System;
using System.Text;

namespace TemplatePractice.Uno;

internal class UnoHumanPlayer : Player
{
    public override Card ShowCard()
    {
        Console.WriteLine("Select a card to play");
        var cardCount = Hand._cards.Count;
        var output = new StringBuilder();
        for (var index = 0; index < cardCount; index++)
        {
            var card = Hand._cards[index];
            output.AppendLine($"{index}. {card.ToString()}");
        }

        Console.WriteLine(output.ToString());
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

        if (parse < 0 || parse >= cardCount)
        {
            Console.WriteLine("Input out of range.");
            return ShowCard();
        }

        var selectedCard = Hand._cards[parse];
        Hand._cards.Remove(selectedCard);
        return selectedCard;
    }
}