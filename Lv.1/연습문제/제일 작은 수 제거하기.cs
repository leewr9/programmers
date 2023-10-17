using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 제일_작은_수_제거하기
    {
        public int[] solution(int[] arr)
        {
            int[] answer = new int[arr.Length - 1];

            if (answer.Length == 0)
                return new int[] { -1 };

            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != min)
                    answer[index++] = arr[i];
            }

            return answer;
        }
    }
}
