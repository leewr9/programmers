using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.Summer_Winter_Coding
{
    internal class 방문_길이
    {
        public int solution(string dirs)
        {
            int answer = 0;

            string[] check = new string[dirs.Length * 2];
            int x = 0;
            int y = 0;

            for (int i = 0; i < dirs.Length; i++)
            {
                int mx = x;
                int my = y;

                if (dirs[i] == 'U' && y > -5)
                    y--;
                else if (dirs[i] == 'D' && y < 5)
                    y++;
                else if (dirs[i] == 'L' && x > -5)
                    x--;
                else if (dirs[i] == 'R' && x < 5)
                    x++;
                else
                    continue;

                string normal = string.Format("{0},{1}=>{2},{3}", my, mx, y, x);
                string reverse = string.Format("{0},{1}=>{2},{3}", y, x, my, mx);

                for (int j = 0; j < check.Length; j++)
                {
                    if (check[j] == normal || check[j] == reverse)
                    {
                        normal = string.Empty;
                        reverse = string.Empty;
                    }
                }

                check[i] = normal;
                check[i + dirs.Length] = reverse;
            }

            for (int i = 0; i < check.Length / 2; i++)
                if (!string.IsNullOrEmpty(check[i]))
                    answer++;

            return answer;
        }
    }
}
