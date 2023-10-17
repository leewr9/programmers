using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class N개의_최소공배수
    {
        public int solution(int[] arr)
        {
            int answer = 0;
            long max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                max *= arr[i];
            }

            for (int i = 1; i < max + 1; i++)
            {
                bool math = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i % arr[j] != 0)
                    {
                        math = false;
                        break;
                    }
                }

                if (math)
                {
                    answer = i; 
                    break;
                }
            }

            return answer;
        }
    }
}
