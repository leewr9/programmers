using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 가장_가까운_같은_글자
    {
        public int[] solution(string s)
        {
            int[] answer = new int[s.Length];
            int[] count = new int[26];

            for (int i = 0; i < count.Length; i++)
                count[i] = -1;

            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 97;

                if (count[index] == -1)
                    answer[i] = -1;
                else
                    answer[i] = i - count[index];

                count[index] = i;
            }

            Console.WriteLine(string.Join(", ", answer));

            return answer;
        }
    }
}
