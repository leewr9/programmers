using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 서울에서_김서방_찾기
    {
        public string solution(string[] seoul)
        {
            string answer = "";

            for (int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == "Kim")
                {
                    answer = string.Format("김서방은 {0}에 있다", i);
                    break;
                }
            }

            return answer;
        }
    }
}
