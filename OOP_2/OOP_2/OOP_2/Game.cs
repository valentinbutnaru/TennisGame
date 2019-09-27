using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    abstract class Game
    {        
        public abstract string getResult(int i,int j) ;
        public abstract string actualScore(int i, int j);
        public abstract string getSame(int i);
    }
}
