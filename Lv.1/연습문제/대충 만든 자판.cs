using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 대충_만든_자판
    {
        public int[] solution(string[] keymap, string[] targets)
        {
            int[] answer = new int[targets.Length];

            for (int i = 0; i < targets.Length; i++)
            {
                for (int j = 0; j < targets[i].Length; j++)
                {
                    int index = 100;

                    for (int k = 0; k < keymap.Length; k++)
                    {
                        int find = keymap[k].IndexOf(targets[i][j]) + 1;
                        if (find > 0 && index > find)
                            index = find;
                    }

                    if (index == 100)
                    {
                        index = -1;
                        answer[i] = index;
                        break;
                    }

                    answer[i] += index;
                }
            }

            return answer;
        }
    }
}
