using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.월간_코드_챌린지
{
    internal class 쿼드압축_후_개수_세기
    {
        public int[] solution(int[,] arr)
        {
            int[] answer = new int[2];
            int[,] quad = new int[arr.GetLength(0), arr.GetLength(1)];

            while (quad.GetLength(0) > 1)
            {
                quad = new int[quad.GetLength(0) / 2, quad.GetLength(1) / 2];

                int u = 0;
                for (int i = 0; i < arr.GetLength(0); i += 2)
                {
                    int q = 0;
                    for (int j = 0; j < arr.GetLength(1); j += 2)
                    {
                        if (arr[i, j] == 1 && arr[i, j + 1] == 1 && arr[i + 1, j] == 1 && arr[i + 1, j + 1] == 1)
                        {
                            quad[u, q] = 1;

                            arr[i, j] = -1;
                            arr[i, j + 1] = -1;
                            arr[i + 1, j] = -1;
                            arr[i + 1, j + 1] = -1;
                        }
                        else if (arr[i, j] == 0 && arr[i, j + 1] == 0 && arr[i + 1, j] == 0 && arr[i + 1, j + 1] == 0)
                        {
                            quad[u, q] = 0;

                            arr[i, j] = -1;
                            arr[i, j + 1] = -1;
                            arr[i + 1, j] = -1;
                            arr[i + 1, j + 1] = -1;
                        }
                        else
                            quad[u, q] = -1;
                        q++;
                    }
                    u++;
                }

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] == 0)
                            answer[0]++;
                        else if (arr[i, j] == 1)
                            answer[1]++;
                    }
                }

                arr = quad;
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                        answer[0]++;
                    else if (arr[i, j] == 1)
                        answer[1]++;
                }
            }

            return answer;
        }
    }
}
