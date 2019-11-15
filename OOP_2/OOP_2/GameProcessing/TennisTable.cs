using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class TennisTable : ITennisTable
    {
        private  PlayerModel _player1;
        private  PlayerModel _player2;
        private readonly ITennisRules _tennisRules;

        public TennisTable(ITennisRules tennisRules)
        {
            _tennisRules = tennisRules;
        }
        public void PlayerStart(string player1Name,string player2Name)
        {
            _player1 = new PlayerModel(player1Name);
            _player2 = new PlayerModel(player2Name);
        }
        public void WonPoint(string playerName)
        { 
            if (playerName == _player1.Name)
                _player1.PlayerScore++;
            else
                _player2.PlayerScore++;
        }
        public string getFinalResult()
        {
            if (_player1.PlayerScore == _player2.PlayerScore)
                return _tennisRules.getSame(_player1.PlayerScore);

            else if (_player1.PlayerScore >= 4 || _player2.PlayerScore >= 4)
                return _tennisRules.getResult(_player1.PlayerScore, _player2.PlayerScore);

            return _tennisRules.actualScore(_player1.PlayerScore, _player2.PlayerScore);
        }
    }
}
