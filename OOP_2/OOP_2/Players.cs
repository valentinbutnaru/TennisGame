using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Players : IPlayer
    {
        private int player_score = 0;
        private string name;
        public Players (string n)
        {
            name = n;
        }
        public void setScore(int point)
        {
            player_score += point;
        }
        public int getScore()
        {
            return player_score;
        }     
        public int Point()
        {
            return 1;
        }
    }
}
