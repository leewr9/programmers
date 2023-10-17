using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 정수_제곱근_판별
    {
        public long solution(long n)
        {
            long math = (long)Math.Sqrt(n);
            if (math * math != n)
                return -1;

            long answer = (math + 1) * (math + 1);

            return answer;
        }
    }
}
