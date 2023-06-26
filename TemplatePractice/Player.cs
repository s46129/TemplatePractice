namespace TemplatePractice;

internal class Player
{
    public string Name { get; private set; }

    public void NameHimSelf(string name)
    {
        Name = name;
    }
}