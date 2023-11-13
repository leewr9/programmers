using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 무인도_여행
    {
        public int[] solution(string[] maps)
        {
            int[] sum = new int[maps.Length * maps[0].Length];
            int count = 0;
            for (int i = 0; i < maps.Length; i++)
            {
                for (int j = 0; j < maps[i].Length; j++)
                {
                    if (maps[i][j] != 'X')
                    {
                        sum[count] = visit(maps, i, j);
                        count++;
                    }
                }
            }

            if (count == 0)
                return new int[] { -1 };

            int[] answer = new int[count];
            int index = 0;
            for (int i = 0; i < sum.Length; i++)
                if (sum[i] > 0)
                    answer[index++] = sum[i];

            Array.Sort(answer);

            return answer;
        }

        public int visit(string[] maps, int x, int y)
        {
            int sum = maps[x][y] - 48;

            char[] convert = maps[x].ToCharArray();
            convert[y] = 'X';
            maps[x] = string.Join("", convert);

            if (y < maps[x].Length - 1 && maps[x][y + 1] != 'X')
                sum += visit(maps, x, y + 1);

            if (x < maps.Length - 1 && maps[x + 1][y] != 'X')
                sum += visit(maps, x + 1, y);

            if (y > 0 && maps[x][y - 1] != 'X')
                sum += visit(maps, x, y - 1);

            if (x > 0 && maps[x - 1][y] != 'X')
                sum += visit(maps, x - 1, y);

            return sum;
        }
    }
}
