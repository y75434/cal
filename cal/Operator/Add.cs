using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal.Operators
{
    class Add : Operator

    {
        public Add (int number1, int number2): base(number1, number2)
        {

        }
       public void test()
        {

        }
        public override int Result()
        {
           return this.number1 + this.number2;
        }
    }
}
