using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.스택_큐
{
    internal class 올바른_괄호
    {
        public bool solution(string s)
        {
            bool answer = s[0] == '(';

            if (answer)
            {
                int count = 0;

                for (int i = 0; i < s.Length; i++) 
                {
                    if (s[i] == '(')
                        count++;
                    else
                    {
                        count--;
                        if (count < 0)
                            break;
                    }
                }

                answer = (count == 0);
            }

            return answer;
        }
    }
}
