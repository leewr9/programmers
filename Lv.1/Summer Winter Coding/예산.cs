using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.Summer_Winter_Coding
{
    internal class 예산
    {
        public int solution(int[] d, int budget)
        {
            int answer = 0;

            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[i] < d[j])
                    {
                        int next = d[i];
                        d[i] = d[j];
                        d[j] = next;
                    }
                }
            }

            for (int i = 0; i < d.Length; i++)
            {
                budget -= d[i];
                if (budget < 0)
                    break;
                answer++;
            }

            return answer;
        }
    }
}
