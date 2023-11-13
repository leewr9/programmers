using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.완전탐색
{
    internal class 전력망을_둘로_나누기
    {
        public int solution(int n, int[,] wires)
        {
            int answer = n;

            int[,] result = new int[n, 2];
            int m = 0;

            while (m < n)
            {
                int[,] check = new int[n, n];
                int[] count = new int[n];
                int[] index = new int[n];

                for (int i = 0; i < wires.GetLength(0); i++)
                {
                    if (i == m)
                        continue;

                    int start = wires[i, 0] - 1;
                    int end = wires[i, 1] - 1;

                    check[end, index[end]++] = start + 1;
                    check[start, index[start]++] = end + 1;

                    count[end]++;
                    count[start]++;
                }

                for (int i = 0; i < check.GetLength(0); i++)
                {
                    int wire = find(check, new int[] { i }, i);
                    if (result[m, 0] == 0)
                        result[m, 0] = wire;
                    else if (result[m, 0] != wire)
                        result[m, 1] = wire;
                }
                m++;
            }

            for (int i = 0; i < result.GetLength(0); i++)
            {
                if (result[i, 0] == n / 2)
                    return 0;

                int min = Math.Abs(result[i, 0] - result[i, 1]);
                if (answer > min)
                    answer = min;
            }
            
            return answer;
        }

        public int find(int[,] wires, int[] before, int idx)
        {
            if (idx > -1)
            {
                int count = 1;
                for (int i = 0; i < wires.GetLength(1); i++)
                {
                    if (wires[idx, i] - 1 > -1)
                    {
                        bool check = false;

                        int[] copy = new int[before.Length + 1];
                        for (int j = 0; j < before.Length; j++)
                        {
                            copy[j] = before[j];
                            if (copy[j] == wires[idx, i] - 1)
                                check = true;
                        }

                        if (!check)
                        {
                            copy[copy.Length - 1] = idx;
                            count += find(wires, copy, wires[idx, i] - 1);
                        }
                    }
                }

                return count;
            }

            return 0;
        }
    }

}
