using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.완전탐색
{
    internal class 최소직사각형
    {
        public int solution(int[,] sizes)
        {
            int answer = 0;

            int x = 0;
            int y = 0;

            for (int i = 0; i < sizes.Length / 2; i++)
            {
                if (sizes[i, 1] > sizes[i, 0])
                {
                    int size = sizes[i, 1];
                    sizes[i, 1] = sizes[i, 0];
                    sizes[i, 0] = size;
                }

                if (x < sizes[i, 0])
                    x = sizes[i, 0];
                if (y < sizes[i, 1]) 
                    y = sizes[i, 1];
            }

            answer = x * y;

            return answer;
        }
    }
}
