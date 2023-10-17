using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.탐욕법
{
    internal class 체육복
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = -1;

            int[] suit = new int[n + 1];

            for (int i = 0; i < suit.Length; i++)
            {
                suit[i]++;
            }

            for (int i = 0; i < lost.Length; i++)
            {
                suit[lost[i]]--;
            }

            for (int i = 0; i < reserve.Length; i++)
            {
                suit[reserve[i]]++;
            }

            for (int i = 0; i < suit.Length; i++)
            {
                if (suit[i] == 0)
                {
                    if (i - 1 > 0 && suit[i - 1] > 1)
                    {
                        suit[i]++;
                        suit[i - 1]--; answer++;
                    }
                    else if (i + 1 < suit.Length && suit[i + 1] > 1)
                    {
                        suit[i]++;
                        suit[i + 1]--; answer++;
                    }
                }
                else
                {
                    answer++;
                }
            }

            return answer;
        }
    }
}
