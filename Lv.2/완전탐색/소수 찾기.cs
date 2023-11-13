using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.완전탐색
{
    internal class 소수_찾기
    {
        public int solution(string numbers)
        {
            int answer = 0;
            for (int i = 2; i < 10000001; i++)
            {
                string s = i.ToString();
                bool check = false;

                if (s.Length > numbers.Length)
                    break;

                for (int j = 0; j < s.Length; j++)
                {
                    if (!numbers.Contains(s[j]))
                    {
                        check = true;
                        break;
                    }
                }

                if (check)
                    continue;

                char[] c = s.ToCharArray();
                for (int j = 0; j < numbers.Length; j++)
                {
                    for (int k = 0; k < c.Length; k++)
                    {
                        if (numbers[j] == c[k])
                        {
                            c[k] = ' ';
                            break;
                        }
                    }
                }

                for (int j = 0; j < c.Length; j++)
                {
                    if (c[j] != ' ')
                    {
                        check = true;
                        break;
                    }
                }

                if (check)
                    continue;

                bool frime = true;
                for (int l = 2; l < i; l++)
                {
                    if (i % l == 0)
                    {
                        frime = false;
                        break;
                    }
                }

                if (frime)
                    answer++;
            }

            return answer;
        }
    }
}
