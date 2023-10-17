using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 연속_부분_수열_합의_개수
    {
        public int solution(int[] elements)
        {
            int answer = 0;
            int max = 0;

            for (int i =0; i < elements.Length; i++)
            {
                max += elements[i];
            }

            int[] sum = new int[max + 1];

            int count = 0;
            while (count < elements.Length)
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    int check = elements[i];
                    int index = i + 1;

                    for (int j = 0; j < count; j++)
                    {
                        if (index > elements.Length - 1)
                            index = 0;

                        check += elements[index++];
                    }

                    sum[check]++;
                }

                count++;
            }


            for (int i = 0; i < sum.Length; i++)
            {
                if (sum[i] > 0)
                    answer++;
            }

            return answer;
        }
    }
}
