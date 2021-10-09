using cal.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    class OperatorFactory
    {
        public static Operator create(int number1, int number2, String Oper)
        {
            Operator oper = null;
            switch (Oper)
            {//只有+-*/使用到多型 數字沒有
                case "+":
                    oper = new Add(number1, number2);
                    //用 ans. 找的到test
                    break;
                case "-":
                    oper = new Minus(number1, number2);

                    break;
                case "*":
                    oper = new Mutli(number1, number2);

                    break;
                case "/":
                    oper = new Division(number1, number2);
                    break;
            }
            return oper;
        }
    }
}
