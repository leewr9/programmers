using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 소수_찾기
    {
        public int solution(int n)
        {
            int answer = 0;

            int[] count = new int[n + 1];
            for (int i = 2; i < n + 1; i++)
            {
                if (count[i] == 1)
                    continue;
                
                for (int j = i + i; j < n + 1; j = j + i)
                {
                    if (j % i == 0)
                        count[j] = 1;
                }
            }

            for(int i = 2; i < count.Length; i++)
            {
                if (count[i] == 0)
                    answer++;
            }

            Console.WriteLine(answer);
            return answer;
        }
    }
}
