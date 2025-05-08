using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
 
namespace Problemex2_4
{
    class Counter
    {
        //  カウント
        private int count = 0;
        //  コンストラクタ
        public void Reset()
        {
            count = 0;
        }
        //  カウントのインクリメント
        public void Increment()
        {
            count++;
        }
        //  回数のプロパティ
        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}