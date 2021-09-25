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
            Operator ans = null; 
            switch (Oper)
            {
                case "+":
                    ans = new Add(this.number1, this.number2);
      
                    break;
                case "-":
                    ans = new Minus(this.number1, this.number2);
       
                    break;
                case "*":
                    ans = new Mutli(this.number1, this.number2);

                    break;
                case "/":
                    ans = new Division(this.number1, this.number2);
                    break;
            }
          

            return ans.Result();

        
    }
}
