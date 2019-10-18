using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class TennisRules : ITennisRules
    {
        public  string Result { get; set; }
        public string getResult(int player_score1,int player_score2)
        {
            var minusResult = player_score1-player_score2;
            if (minusResult == 1) Result = "Advantage player1";
            else if (minusResult == -1) Result = "Advantage player2";
            else if (minusResult >= 2) Result = "Win for player1";
            else Result = "Win for player2";
            return Result;
        }
        public  string getSame(int players_score)
        {
            switch (players_score)
            {
                case 0:
                    Result = "Love-All";
                    break;
                case 1:
                    Result = "Fifteen-All";
                    break;
                case 2:
                    Result = "Thirty-All";
                    break;
                default:
                    Result = "Deuce";
                    break;

            }
            return Result;
        }
        public  string actualScore(int player_score1,int player_score2)
        {
            Result = "";
            int tempScore;
            for (var i = 1; i < 3; i++)
            {
                if (i == 1) tempScore = player_score1;
                else { Result += "-"; tempScore = player_score2; }
                switch (tempScore)
                {
                    case 0:
                        Result += "Love";
                        break;
                    case 1:
                        Result += "Fifteen";
                        break;
                    case 2:
                        Result += "Thirty";
                        break;
                    case 3:
                        Result += "Forty";
                        break;
                }
            }
            return Result;
        }
    }
}
