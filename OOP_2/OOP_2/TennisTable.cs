using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class TennisTable:TennisGame
    {
        protected Players player1;
        protected Players player2;
        public TennisTable (string p1,string p2)
        {
            player1 = new Players(p1);
            player2 = new Players(p2);
        }
        public void WonPoint(string PlayerName)
        {
            if (PlayerName == player1.Name)
                player1.Player_Score++;
            else
                player2.Player_Score++;
        }
        public string getFinalResult()
        {
            if (player1.Player_Score == player2.Player_Score)
                return getSame(player1.Player_Score);
            else if (player1.Player_Score >= 4 || player2.Player_Score >= 4)
                return getResult(player1.Player_Score, player2.Player_Score);
            return actualScore(player1.Player_Score, player2.Player_Score);           
        }
    }
}
