using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1
{
    internal class 숫자_짝꿍
    {
        public string solution(string X, string Y)
        {
            StringBuilder sb = new StringBuilder();

            int[][] count = new int[10][];

            for (int i = 0; i < X.Length; i++)
            {
                int num = (X[i] - 48);
                if (count[num] == null)
                    count[num] = new int[2];

                int find = Y.IndexOf(X[i], count[num][1]);
                if (find > -1)
                {
                    count[num][0]++;
                    count[num][1] = find + 1;
                }
            }

            for (int i = count.Length - 1; i > -1; i--)
            {
                if (count[i] != null && count[i][0] > 0)
                {
                    for (int j = 0; j < count[i][0]; j++)
                        sb.Append(i);
                }
            }

            string answer = sb.ToString();

            if (int.TryParse(answer, out int zero) && zero == 0)
                return "0";

            if (string.IsNullOrEmpty(answer))
                return "-1";

            return answer;
        }
    }
}
