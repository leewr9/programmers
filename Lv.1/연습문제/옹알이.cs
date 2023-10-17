using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 옹알이
    {
        public int solution(string[] babbling)
        {
            int answer = 0;

            string[] lang = { "aya", "ye", "woo", "ma" };

            for (int i = 0; i < lang.Length; i++)
            {
                for (int j = 0; j < babbling.Length; j++)
                {
                    if (babbling[j].Contains(lang[i] + lang[i]))
                        continue;

                    babbling[j] = babbling[j].Replace(lang[i], "0");
                }
            }

            for (int i = 0; i < babbling.Length; i++)
            {
                if (int.TryParse(babbling[i], out _))
                    answer++;
            }

            return answer;
        }
    }
}
