﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal.Operators
{

    class Mutli : Operator 
    {
        public Mutli(int number1, int number2) : base(number1, number2)
        {
        }

        public override int Result()
        {
            return number1 * number2;
        }
    }
}
