using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.정렬
{
    internal class H_Index
    {
        public int solution(int[] citations)
        {
            int answer = 0;
            
            for (int i = 1; i < 10001; i++)
            {
                int count = 0;

                for (int j = 0; j < citations.Length; j++)
                {
                    if (citations[j] >= i)
                        count++;
                }

                if (count < i)
                {
                    answer = i - 1;
                    break;
                }
            }

            return answer;
        }
    }
}
