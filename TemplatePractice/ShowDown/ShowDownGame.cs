namespace TemplatePractice.ShowDown;

internal class ShowDownGame : GameFlow
{
    public override void Start()
    {
        base.Start();
    }

    protected override Player CreateHunamdPlayer()
    {
        return new ShowDownPlayer();
    }

    protected override Player CreateComputerPlayer()
    {
        return new ShowDownAiPlayer();
    }

    protected override void End()
    {
        base.End();
    }
}