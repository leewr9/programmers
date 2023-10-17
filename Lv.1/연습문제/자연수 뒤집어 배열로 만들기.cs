using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 자연수_뒤집어_배열로_만들기
    {
        public int[] solution(long n)
        {
            string s = n.ToString();
            int[] answer = new int[s.Length];

            int index = s.Length - 1;
            for (int i = 0; i < s.Length; i++) 
                answer[index--] = s[i] - 48;

            return answer;
        }
    }
}
