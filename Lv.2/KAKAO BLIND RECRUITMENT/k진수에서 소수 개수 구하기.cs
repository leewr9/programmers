using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.KAKAO_BLIND_RECRUITMENT
{
    internal class k진수에서_소수_개수_구하기
    {
        public int solution(int n, int k)
        {
            int answer = 0;

            string binary = string.Empty;
            while (n > 0)
            {
                binary = (n % k).ToString() + binary;
                n = n / k;
            }

            string[] num = binary.Split('0');
            for (int i = 0; i < num.Length; i++)
            {
                if (!string.IsNullOrEmpty(num[i]) && num[i] != "1")
                {
                    long convert = long.Parse(num[i]);
                    bool frime = true;

                    for (int j = 2; j <= Math.Sqrt(convert); j++)
                    {
                        if (convert % j == 0)
                        {
                            frime = false;
                            break;
                        }
                    }

                    if (frime)
                        answer++;
                }
            }

            return answer;
        }
    }
}
