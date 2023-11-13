using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.해시
{
    internal class 의상
    {
        public int solution(string[,] clothes)
        {
            int answer = 1;

            string[] cloth = new string[clothes.GetLength(0)];
            int[] count = new int[clothes.GetLength(0)];

            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                bool add = false;
                for (int j = 0; j < cloth.Length; j++)
                {
                    if (clothes[i, 1] == cloth[j])
                    {
                        count[j]++;
                        add = true;
                        break;
                    }
                }

                if (!add)
                {
                    cloth[i] = clothes[i, 1];
                    count[i]++;
                }
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                    answer *= (count[i] + 1);
            }

            return answer - 1;
        }
    }
}
