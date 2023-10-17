using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 나누어_떨어지는_숫자_배열
    {
        public int[] solution(int[] arr, int divisor)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                    if (arr[i] % divisor == 0)
                        count++;
                    else
                        arr[i] = -1;
            }

            if (count == 0)
                return new int[] { -1 };

            int[] answer = new int[count];

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > -1)
                    answer[index++] = arr[i];
            }

            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = 0; j < answer.Length; j++)
                {
                    if (answer[i] > answer[j])
                    {
                        int next = answer[i];
                        answer[i] = answer[j];
                        answer[j] = next;
                    }
                }
            }

            return answer;
        }
    }
}
