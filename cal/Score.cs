using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    class Score
    {
        public String name;
        private int _score;
        public int Value
        {
            get
            {
                return _score;
            }
            set
            {
                if (value > 100) _score = 100;
                else if (value < 0) _score = 0;
                else _score = value;
            }
        }
        public void printScore()
        {
            Console.WriteLine($"{name} {_score}");
        }
    }
}
