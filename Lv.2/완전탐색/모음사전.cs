using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.완전탐색
{
    internal class 모음사전
    {
        public int solution(string word)
        {
            int answer = 0;

            int start = 4;
            for (int i = 0; i < word.Length; i++)
            {
                int num = 1;
                int count = 1;

                for (int j = 0; j < start; j++)
                {
                    count *= 5;
                    count += num;
                }

                count -= num;
                start--;

                if (word[i] == 'E')
                    num = 2;
                else if (word[i] == 'I')
                    num = 3;
                else if (word[i] == 'O')
                    num = 4;
                else if (word[i] == 'U')
                    num = 5;

                answer += (count * (num - 1)) + num;
            }

            return answer;
        }
    }
}
