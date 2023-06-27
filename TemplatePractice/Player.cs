namespace TemplatePractice;

internal abstract class Player
{
    public string Name { get; private set; }

    public readonly Hand Hand = new Hand();

    public void NameHimSelf(string name)
    {
        Name = name;
    }

    public abstract Card ShowCard();
}