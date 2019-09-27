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
            if (PlayerName == "player1")
                player1.setScore(player1.Point());
            else
                player2.setScore(player2.Point());
        }
        public string getFinalResult()
        {
            if (player1.getScore() == player2.getScore())
                return getSame(player1.getScore());
            else if (player1.getScore() >= 4 || player2.getScore() >= 4)
                return getResult(player1.getScore(), player2.getScore());
            return actualScore(player1.getScore(), player2.getScore());           
        }
    }
}
