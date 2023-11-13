using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 마법의_엘리베이터
    {
        public int solution(int storey)
        {
            int answer = 0;
            int before = 0;
            while (storey > 0)
            {
                int btn = storey % 10;
                storey = storey / 10;

                Console.WriteLine(storey + " = " + btn);

                if (btn >= 5)
                {
                    storey++;
                    btn = 10 - btn;
                }
                Console.WriteLine("> " + storey + " = " + btn);

                answer += btn;

                if (storey < 10)
                {
                    if (storey >= 5)
                    {
                        storey += 10;
                        answer++;
                    }
                    else
                        storey = 0;
                }
            }

            Console.WriteLine(answer);
            Console.WriteLine();

            return answer;
        }
    }
}
