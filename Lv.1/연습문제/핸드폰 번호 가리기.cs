using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 핸드폰_번호_가리기
    {
        public string solution(string phone_number)
        {
            string answer = "";

            for (int i = 0; i < phone_number.Length - 4; i++)
                answer += "*";

            return answer + phone_number.Substring(phone_number.Length - 4);
        }
    }
}
