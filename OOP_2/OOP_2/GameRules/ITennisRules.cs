namespace OOP_2
{
    public interface ITennisRules
    {
        string Result { get; set; }

        string actualScore(int player_score1, int player_score2);
        string getResult(int player_score1, int player_score2);
        string getSame(int players_score);
    }
}