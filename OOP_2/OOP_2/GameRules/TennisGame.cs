using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class TennisGame:IGame
    {
        private string result ;
        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        public string getResult(int player_score1,int player_score2)
        {
            var minusResult = player_score1-player_score2;
            if (minusResult == 1) result = "Advantage player1";
            else if (minusResult == -1) result = "Advantage player2";
            else if (minusResult >= 2) result = "Win for player1";
            else result = "Win for player2";
            return result;
        }
        public  string getSame(int players_score)
        {
            switch (players_score)
            {
                case 0:
                    result = "Love-All";
                    break;
                case 1:
                    result = "Fifteen-All";
                    break;
                case 2:
                    result = "Thirty-All";
                    break;
                default:
                    result = "Deuce";
                    break;

            }
            return result;
        }
        public  string actualScore(int player_score1,int player_score2)
        {
            result = "";
            int tempScore;
            for (var i = 1; i < 3; i++)
            {
                if (i == 1) tempScore = player_score1;
                else { result += "-"; tempScore = player_score2; }
                switch (tempScore)
                {
                    case 0:
                        result += "Love";
                        break;
                    case 1:
                        result += "Fifteen";
                        break;
                    case 2:
                        result += "Thirty";
                        break;
                    case 3:
                        result += "Forty";
                        break;
                }
            }
            return result;
        }
    }
}
