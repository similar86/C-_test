using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Problem6_2
{
    //  最大値と最小値を求めるクラス
    class Calc
    {
        //  足し算
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        //  引き算
        public double Sub(double n1, double n2)
        {
            return n1 - n2;
        }
        //掛け算
        public double Mul(double n1, double n2)
        {
            return n1 * n2;
        }
        //割り算
        public double Div(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}