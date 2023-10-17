using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.정렬
{
    internal class K번째수
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int length = (commands.Length / 3);
            int[] answer = new int[length];

            for (int i = 0; i < length; i++)
            {
                int[] sort = new int[(commands[i, 1] - commands[i, 0]) + 1];

                for (int j = commands[i, 0] - 1; j < commands[i, 1]; j++)
                {
                    sort[j - (commands[i, 0] - 1)] = array[j];
                }

                for (int j = 0; j < sort.Length; j++)
                {
                    for(int k = 0; k < sort.Length; k++)
                    {
                        if (sort[j] < sort[k])
                        {
                            int next = sort[j];
                            sort[j] = sort[k];
                            sort[k] = next;
                        }
                    }
                }

                answer[i] = sort[commands[i, 2] - 1];
            }

            return answer;
        }
    }
}
