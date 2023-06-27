namespace TemplatePractice.Uno;

public class UnoCard : Card
{
    public readonly int Number;

    public readonly Colors Color;

    public UnoCard(Colors colors, int number)
    {
        this.Number = number;
        this.Color = colors;
    }

    public override int CompareTo(Card other)
    {
        throw new System.NotImplementedException();
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