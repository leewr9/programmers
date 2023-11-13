using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.깊이_너비_우선_탐색_DFS_BFS_
{
    internal class 게임_맵_최단거리
    {
        public int solution(int[,] maps)
        {
            int answer = 0;

            int[,,] point = new int[4, 4, 2];

            while (answer == 0)
            {
                for (int i = 0; i < point.GetLength(0); i++)
                {
                    if (point[i, 0, 0] - 1 > -1 && maps[point[i, 0, 0] - 1, point[i, 0, 1]] == 1)
                        point[i, 0, 0]--;
                    if (point[i, 1, 0] + 1 < maps.GetLength(0) && maps[point[i, 0, 0] + 1, point[i, 0, 1]] == 1)
                        point[i, 1, 0]++;
                    if (point[i, 2, 1] > -1 && maps[point[i, 0, 0], point[i, 0, 1] - 1] == 1)
                        point[i, 2, 1]--;
                    if (point[i, 3, 1] + 1 < maps.GetLength(1) && maps[point[i, 0, 0], point[i, 0, 1] + 1] == 1)
                        point[i, 3, 1]++;

                    Console.WriteLine(point[i, 0, 0] + " , " + point[i, 0, 1]);
                }
            }

            return answer;
        }

        public int solution2(int[,] maps)
        {
            int answer = move(maps, 0, 0, 0);

            if (answer == (maps.GetLength(0) * maps.GetLength(1)) + 1)
                return -1;
            
            return answer;
        }

        public int move(int[,] maps, int x, int y, int count)
        {
            int[] check = new int[4];
            int min = (maps.GetLength(0) * maps.GetLength(1)) + 1;

            if (x == maps.GetLength(1) - 1 && y == maps.GetLength(0) - 1)
                return count + 1;

            maps[y, x] = -1;
            count++;

            if (y - 1 > -1)
            {
                if (maps[y - 1, x] == 1)
                    check[0] = move(maps, x, y - 1, count);
            }

            if (y + 1 < maps.GetLength(0))
            {
                if (maps[y + 1, x] == 1)
                    check[1] = move(maps, x, y + 1, count);
            }

            if (x - 1 > -1)
            {
                if (maps[y, x - 1] == 1)
                    check[2] = move(maps, x - 1, y, count);
            }

            if (x + 1 < maps.GetLength(1))
            {
                if (maps[y, x + 1] == 1)
                    check[3] = move(maps, x + 1, y, count);
            }

            maps[y, x] = 1;

            for (int i = 0; i < check.Length; i++)
            {
                if (min > check[i] && check[i] > 0)
                    min = check[i];
            }

            return min;
        }
    }
}
