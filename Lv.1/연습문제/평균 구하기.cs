using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 평균_구하기
    {
        public double solution(int[] arr)
        {
            double answer = 0;

            for (int i = 0; i < arr.Length; i++)
                answer += arr[i];

            return answer / arr.Length;
        }
    }
}
