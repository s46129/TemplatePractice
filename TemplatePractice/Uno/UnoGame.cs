namespace TemplatePractice.Uno;

internal class UnoGame : GameFlow
{
    protected override Player CreateHunamdPlayer()
    {
        return new UnoHumanPlayer();
    }

    protected override Player CreateComputerPlayer()
    {
        return new UnoComputerPlayer();
    }

}