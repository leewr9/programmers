using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.연습문제
{
    internal class 최솟값_만들기
    {
        public int solution(int[] A, int[] B)
        {
            int answer = 0;

            Array.Sort(A);
            Array.Sort(B);
            Array.Reverse(B);

            for (int i = 0; i < A.Length; i++)
                answer += A[i] * B[i];

            return answer;
        }
    }
}
