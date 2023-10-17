using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 귤_고르기
    {
        public int solution(int k, int[] tangerine)
        {
            int answer = 0;

            Array.Sort(tangerine);

            int[] size = new int[tangerine[tangerine.Length - 1]];
            for (int i = 0; i < tangerine.Length; i++)
            {
                size[tangerine[i] - 1]++;
            }

            Array.Sort(size);

            for (int i = size.Length - 1; i > -1; i--)
            {
                answer++;
                k -= size[i];
                if (k < 1)
                    break;
            }

            return answer;
        }
    }
}
