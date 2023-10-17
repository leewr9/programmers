using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 피보나치_수
    {
        public ulong solution(int n)
        {
            ulong answer = fibonnaci(0, 1, n);

            return answer;
        }

        public ulong fibonnaci(ulong i, ulong j, int n)
        {
            if (n == 1)
                return j;
            n--;

            return fibonnaci((j % 1234567), ((i + j) % 1234567), n);
        }
    }
}
