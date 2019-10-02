using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Players
    {
        private int player_score;
        private string name;
        public Players (string n)
        {
            name = n;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Player_Score
        {
            get { return player_score; }
            set { player_score=value; }
        }
    }
}
