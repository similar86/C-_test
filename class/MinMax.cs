using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Problem6_1
{
    //  最大値と最小値を求めるクラス
    class MinMax
    {
        //  最大値の取得
        public int Max(int n1, int n2, int n3)
        {
            if (n1 >= n2)
            {
                if (n1 >= n3)
                {
                    return n1;
                }
                else if (n2 > n1)
                {
                    if (n2 > n3)
                    {
                        return n2;
                    }
                }
            }
            return n3;
        }
        //  最小値の取得
        public int Min(int n1, int n2, int n3)
        {
            if (n1 <= n2)
            {
                if (n1 <= n3)
                {
                    return n1;
                }
                else if (n2 < n1)
                {
                    if (n2 < n3)
                    {
                        return n2;
                    }
                }
            }
            return n3;
        }
    }
}