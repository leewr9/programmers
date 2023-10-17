using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 짝수와_홀수
    {
        public string solution(int num)
        {
            string answer = "Odd";
            if (num % 2 == 0) 
                answer = "Even";

            return answer;
        }
}
}
