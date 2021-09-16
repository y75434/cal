using cal.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal
{
    class Cal
    {
        private int number1;
        public String Number1

        {
            get
            {
                return number1.ToString();
            }
            set
            {
                number1 = int.Parse(value);
            }
        }
        private int number2;
        public String Number2
        {
            get
            {
                return number2.ToString();
            }
            set
            {
                number2 = int.Parse(value);
            }
        }
        public String Oper;

        public int Result()
        {
            int Result = 0;
            switch (Oper)
            {
                case "+":
                    Add add = new Add();
                    Result = add.Result(this.number1 , this.number2);
                    break;
                case "-":
                    Minus minus = new Minus();
                    Result = minus.Result(this.number1 , this.number2);
                    break;
                case "*":
                    Mutli mutli = new Mutli();
                    Result = mutli.Result(this.number1 , this.number2);
                    break;
                case "/":
                    Division division = new Division();
                    Result = division.Result(this.number1 , this.number2);
                    break;
            }
            return Result;
        }

        
    }
}
