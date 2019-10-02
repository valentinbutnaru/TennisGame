using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    interface IGame
    {        
        string getResult(int player1_score,int player2_score) ;
        string actualScore(int player1_score, int player2_score);
        string getSame(int players_score);
    }
}
