using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.월간_코드_챌린지
{
    internal class 삼각_달팽이
    {
        public int[] solution(int n)
        {
            int[,] triangle = new int[n, n];

            int one = 0;
            int two = 1;
            int three = 2;

            int s = 0;

            int snail = 1;
            int max = 0;

            for (int i = 0; i < n; i++)
                max += (i + 1);

            while (snail < max + 1)
            {
                for (int i = one; i < triangle.GetLength(1) - s; i++)
                    triangle[i, s] = snail++;

                for (int i = two; i < triangle.GetLength(0) - one; i++)
                    triangle[triangle.GetLength(1) - 1 - s, i] = snail++;

                for (int i = triangle.GetLength(1) - three; i > one; i--)
                    triangle[i, triangle.GetLength(0) - 1 - s] = snail++;

                one += 2;
                two++;
                three++;

                s++;
            }

            int[] answer = new int[max];
            int index = 0;
            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                for (int j = 0; j < triangle.GetLength(1); j++)
                    if (triangle[i, j] != 0)
                        answer[index++] = triangle[i, j];
            }

            return answer;
        }
    }
}
