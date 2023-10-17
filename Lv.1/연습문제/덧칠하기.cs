using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 덧칠하기
    {
        public int solution(int n, int m, int[] section)
        {
            int answer = 0;
            int last = 0;

            for(int i = 0; i < section.Length; i++)
            {
                if (section[i] < last)
                    continue;

                last = section[i] + m;
                answer++;
            }

            return answer;
        }
    }
}
