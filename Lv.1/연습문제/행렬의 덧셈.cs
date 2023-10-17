using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 행렬의_덧셈
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetUpperBound(0) + 1, arr1.GetUpperBound(1) + 1];

            for (int i = 0; i < answer.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < answer.GetUpperBound(1) + 1; j++)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return answer;
        }
    }
}
