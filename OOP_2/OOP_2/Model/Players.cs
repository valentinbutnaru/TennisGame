using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class PlayerModel
    {
        public int PlayerScore { get; set; }
        public string Name { get; set; }
        public PlayerModel(string n)
        {
            Name = n;
        }
    }
}
