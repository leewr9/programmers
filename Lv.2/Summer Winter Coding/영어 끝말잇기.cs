using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.Summer_Winter_Coding
{
    internal class 영어_끝말잇기
    {
        public int[] solution(int n, string[] words)
        {
            int[] answer = new int[2];

            string record = string.Empty;
            int count = 1;

            for (int i = 0; i < words.Length; i++)
            {
                int number = (i % n);
                if (record.Contains(" " + words[i] + " "))
                {
                    answer[0] = number + 1;
                    answer[1] = count;
                    break;
                }

                record += " " + words[i] + " ";

                if (i > 0)
                {
                    string before = words[i - 1];
                    if (before[before.Length - 1] != words[i][0])
                    {
                        answer[0] = number + 1;
                        answer[1] = count;
                        break;
                    }
                }

                if (number + 1 == n)
                    count++;
            }

            return answer;
        }
    }
}
