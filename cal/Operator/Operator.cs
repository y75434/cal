using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal.Operators
{
    // 多型分為兩種，一種叫抽象類別(Abstract)(已實作+未實作),一種叫介面(Interface)(未實作)
    // 抽象類別有一個特性，可以包含已實作與未實作的方法
    // 目的:限制(規範) 開發者，按照抽象類別定義的規格(欄位&方法名) 來實作
    abstract class Operator
    {
        public int number1 { get; set; }
        public int number2 { get; set; }

        public Operator(int number1 , int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public void test()
        {

        }
        public abstract int Result();
        
       
    }
}
