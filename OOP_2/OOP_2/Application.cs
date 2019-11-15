using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class Application : IApplication
    {
        private readonly ITennisTable _tennisTable;

        public Application(ITennisTable tennisTable)
        {
            _tennisTable = tennisTable;
        }

        public void Run()
        {
            string[] points = { "player1", "player1", "player2", "player2", "player1", "player1" };
            _tennisTable.PlayerStart("player1", "player2");
            for (var i = 0; i < 6; i++)
            {
                _tennisTable.WonPoint(points[i]);
                Console.WriteLine("Score: {0}", _tennisTable.getFinalResult());
            }
        }
    }
}
