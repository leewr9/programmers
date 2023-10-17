using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 바탕화면_정리
    {
        public int[] solution(string[] wallpaper)
        {
            int[] answer =
            {
                wallpaper.Length,
                wallpaper[0].Length,
                -1,
                -1
            };

            for (int i = 0; i < wallpaper.Length; i++)
            {
                int find = -1;
                for (int j = 0; j < wallpaper[i].Length; j++)
                {
                    if (wallpaper[i][j] == '#')
                    {
                        find = j; 
                        break;
                    }
                }

                if (find > -1)
                {
                    if (find < answer[1])
                        answer[1] = find;

                    if (i < answer[0])
                        answer[0] = i;
                }
            }


            for (int i = wallpaper.Length - 1; i > -1; i--)
            {
                int find = -1;
                for (int j = wallpaper[i].Length - 1; j > -1; j--)
                {
                    if (wallpaper[i][j] == '#')
                    {
                        find = j;
                        break;
                    }
                }

                if (find > -1)
                {
                    if (find >= answer[3])
                        answer[3] = find + 1;

                    if (i >= answer[2])
                        answer[2] = i + 1;
                }
            }

            return answer;
        }
    }
}
