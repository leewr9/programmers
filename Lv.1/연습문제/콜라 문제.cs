using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 콜라_문제
    {
        public int solution(int a, int b, int n)
        {
            int answer = 0;

            while (n >= a)
            {
                int count = (n / a) * b;
                int another = n % a;

                n = count + another;
                Console.WriteLine(n);
                answer += count;
            }

            Console.WriteLine();
            Console.WriteLine(answer);
            Console.WriteLine();
            return answer;
        }
    }
}
