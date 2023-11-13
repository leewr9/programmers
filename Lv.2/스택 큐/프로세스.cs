using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.스택_큐
{
    internal class 프로세스
    {
        public int solution(int[] priorities, int location)
        {
            int answer = 0;

            int start = 0;
            int index = 0;

            int[] sort = new int[priorities.Length];

            while (index < priorities.Length)
            {
                int count = 0;

                int max = 0;
                int find = 0;

                while (count  < priorities.Length)
                {
                    if (max < priorities[start])
                    {
                        max = priorities[start];
                        find = start;
                    }

                    start++;

                    if (start > priorities.Length - 1)
                        start = 0;

                    count++;
                }

                priorities[find] = -1;
                sort[index++] = find;
                start = find;
            }

            for (int i = 0; i < sort.Length; i++)
            {
                if (sort[i] == location)
                {
                    answer = i + 1;
                    break;
                }
            }

            return answer;
        }
    }
}
