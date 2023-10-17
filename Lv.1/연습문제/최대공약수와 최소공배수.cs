using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 최대공약수와_최소공배수
    {
        public int[] solution(int n, int m)
        {
            if (m > n)
            {
                int next = m;
                m = n;
                n = next;
            }

            int[] answer = { n % m, n * m };

            while (answer[0] > 0)
            {
                answer[0] = n % m;

                n = m;
                m = answer[0];
            }

            answer[0] = n;
            answer[1] = answer[1] / n;

            return answer;
        }
    }
}
