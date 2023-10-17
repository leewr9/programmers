using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.팁스타운
{
    internal class 예상_대진표
    {
        public int solution(int n, int a, int b)
        {
            int answer = 0;

            while (a != b)
            {
                answer++;
                a = (a / 2) + (a % 2);
                b = (b / 2) + (b % 2);
            }

            return answer;
        }
    }
}
