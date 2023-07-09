namespace TemplatePractice.Uno;

public class UnoCard : Card
{
    private readonly int Number;

    private readonly Colors Color;

    public UnoCard(Colors colors, int number)
    {
        this.Number = number;
        this.Color = colors;
    }

    public override int CompareTo(Card other)
    {
        //必須與檯面上最新的牌的顏色一樣，或是數字一樣。出完的牌就會成為檯面上最新的牌。
        if (other is not UnoCard card) return -1;
        return card.Color == Color || card.Number == Number ? 0 : -1;
    }

    public override string ToString()
    {
        return $"{Number} of {Color}";
    }

    public enum Colors
    {
        Blue,
        Red,
        Yellow,
        Green
    }
}