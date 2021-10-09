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
            // ans 是父組件 接子組件 子組件繼承父組件數字 各子組件在用不同運算符號做多型 運算結果result在父組件做
            Operator ans = null;
            // 用 ans. 找不到test 因為




            Operator oper = OperatorFactory.create(this.number1, this.number2, this.Oper);
                    
            return oper.Result();
           
           
        }

        
    }
}
