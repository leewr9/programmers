using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.완전탐색
{
    internal class 피로도
    {
        public int solution(int k, int[,] dungeons)
        {
            int answer = 0;
            for (int i = 0; i < dungeons.GetLength(0); i++)
            {
                bool[] check = new bool[dungeons.GetLength(0)];
                check = raid(dungeons, check, i, k);

                int count = 0;
                for (int j = 0; j < check.Length; j++)
                    if (check[j])
                        count++;

                if (answer < count) 
                    answer = count;
            }

            return answer;
        }

        public bool[] raid(int[,] dungeons, bool[] check, int start, int k)
        {
            bool[][] checks = new bool[dungeons.GetLength(0)][];

            if (k >= dungeons[start, 0])
            {
                int sum = k - dungeons[start, 1];
                check[start] = true;

                for (int i = 0; i < dungeons.GetLength(0); i++)
                {
                    checks[i] = new bool[check.Length];
                    for (int j = 0; j < check.Length; j++)
                        checks[i][j] = check[j];

                    if (!checks[i][i])
                        checks[i] = raid(dungeons, checks[i], i, sum);
                }
            }

            int index = 0;
            int max = 0;

            for (int i = 0; i < checks.Length; i++)
            {
                int count = 0;
                if (checks[i] != null)
                    for (int j = 0; j < checks[i].Length; j++)
                        if (checks[i][j])
                            count++;

                if (max < count)
                {
                    max = count;
                    index = i;
                }
            }

            if (checks[index] == null)
                return new bool[check.Length];

            return checks[index];
        }
    }
}
