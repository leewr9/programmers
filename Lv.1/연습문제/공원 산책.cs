using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 공원_산책
    {
        public int[] solution(string[] park, string[] routes)
        {
            int[] answer = new int[2];

            char[][] parks = new char[park.Length][];

            for(int i = 0; i < park.Length; i++)
            {
                if (park[i].IndexOf('S') > -1)
                {
                    answer[0] = i;
                    answer[1] = park[i].IndexOf('S');
                }

                parks[i] = park[i].ToCharArray();
            }

            for (int i = 0; i < routes.Length; i++)
            {
                string[] way = routes[i].Split(' ');

                int x = answer[1];
                int y = answer[0];

                bool move = true;

                switch (way[0]) 
                {
                    case "N":
                        if(y < 0) 
                            move = false;
                        else
                        {
                            for (int j = 0; j < int.Parse(way[1]); j++)
                            {
                                y--;
                                if (y < 0 || parks[y][x] == 'X')
                                {
                                    move = false;
                                    break;
                                }
                            }
                        }
                        break;

                    case "S":
                        if (y > parks.Length - 1)
                            move = false;
                        else
                        {
                            for (int j = 0; j < int.Parse(way[1]); j++)
                            {
                                y++;
                                if (y > parks.Length - 1 || parks[y][x] == 'X')
                                {
                                    move = false;
                                    break;
                                }
                            }
                        }
                        break;

                    case "W":
                        if (x < 0)
                            move = false;
                        else
                        {
                            for (int j = 0; j < int.Parse(way[1]); j++)
                            {
                                x--;
                                if (x < 0 || parks[y][x] == 'X')
                                {
                                    move = false;
                                    break;
                                }
                            }
                        }
                        break;

                    case "E":
                        if (x > parks[0].Length -1) 
                            move = false;
                        else
                        {
                            for (int j = 0; j < int.Parse(way[1]); j++)
                            {
                                x++;
                                if (x > parks[0].Length - 1 || parks[y][x] == 'X')
                                {
                                    move = false;
                                    break;
                                }
                            }
                        }
                        break;
                }

                if (move)
                {
                    answer[0] = y;
                    answer[1] = x;
                }
            }

            return answer;
        }
    }
}
