using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 호텔_대실
    {
        public int solution(string[,] book_time)
        {
            int answer = 0;
            int count = 0;

            int[] in_times = new int[book_time.GetLength(0)];
            int[] out_times = new int[book_time.GetLength(0)];

            for (int i = 0; i < book_time.GetLength(0); i++)
            {
                string[] in_time = book_time[i, 0].Split(':');
                string[] out_time = book_time[i, 1].Split(':');

                in_times[i] = (int.Parse(in_time[0]) * 60) + int.Parse(in_time[1]);
                out_times[i] = (int.Parse(out_time[0]) * 60) + int.Parse(out_time[1]) + 10;
            }

            int[] rooms = new int[book_time.GetLength(0)];
            while (count++ < book_time.GetLength(0)) 
            {
                int early = 1440;
                int index = 0;
                for (int i = 0; i < book_time.GetLength(0); i++)
                {
                    if (early > in_times[i])
                    {
                        early = in_times[i];
                        index = i;
                    }
                }

                for (int i = 0; i < rooms.Length; i++)
                {
                    if (rooms[i] > 0 && rooms[i] <= in_times[index])
                    {
                        rooms[i] = 0;
                        answer--;
                    }

                    if (rooms[i] == 0)
                    {
                        rooms[i] = out_times[index];
                        answer++;
                        break;
                    }
                }

                in_times[index] = 1440;
            }

            return answer;
        }
    }
}
