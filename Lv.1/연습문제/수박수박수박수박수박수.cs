using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 수박수박수박수박수박수
    {
        public string solution(int n)
        {
            string answer = "";

            for(int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    answer += "수";
                else 
                    answer += "박";
            }

            return answer;
        }
    }
}
