using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 약수의_합
    {
        public int solution(int n)
        {
            int answer = 0;

            for(int i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                    answer += i;
            }

            return answer;
        }
    }
}
