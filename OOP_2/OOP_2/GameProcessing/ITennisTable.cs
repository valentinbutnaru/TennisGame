namespace OOP_2
{
    public interface ITennisTable
    {
        string getFinalResult();
        void WonPoint(string PlayerName);
        void PlayerStart(string player1Name, string player2Name);
    }
}