using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.완전탐색
{
    internal class 모의고사
    {
        public int[] solution(int[] answers)
        {
            int[][] student = 
            {
                new int[] { 1, 2, 3, 4, 5 }, 
                new int[] { 2, 1, 2, 3, 2, 4, 2, 5 }, 
                new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 } 
            };

            int[] index = new int[4];
            int[] count = new int[4];

            int length = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                for(int j = 0; j < student.Length; j++)
                {
                    if (student[j][index[j]++] == answers[i])
                    {
                        count[j]++;

                        if (count[3] < count[j])
                        {
                            count[3] = count[j];
                            index[3] = j;
                        }
                    }

                    if (index[j] == student[j].Length)
                        index[j] = 0;
                }
            }

            for (int i = 0; i < count.Length - 1; i++)
            {
                if (count[i] == count[3])
                    length++;
            }

            int[] answer = new int[length];
            while (length > 0)
            {
                int max_index = 0;
                int max = 0;
                for (int i = 0; i < count.Length - 1; i++)
                {
                    if (count[i] > max)
                    {
                        max = count[i];
                        max_index = i;
                    }
                }

                count[max_index] = -1;
                answer[answer.Length - length--] = max_index + 1;
            }

            Console.WriteLine(string.Join(" ", answer));
            Console.WriteLine();

            return answer;
        }
    }
}

