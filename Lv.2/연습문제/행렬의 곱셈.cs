using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 행렬의_곱셈
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

            int y = 0;
            for (int i = 0; i < arr1.GetLength(0);)
            {
                int x = 0;
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    answer[i, y] += arr1[i, j] * arr2[x++, y];
                }
                y++;

                if (y > arr2.GetLength(1) - 1)
                {
                    i++;
                    y = 0;
                }
            }

            return answer;
        }
    }
}
