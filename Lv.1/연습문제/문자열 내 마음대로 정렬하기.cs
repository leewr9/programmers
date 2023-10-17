using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1
{
    internal class 문자열_내_마음대로_정렬하기
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];
            string[] sort = new string[26];

            for (int i = 0; i < strings.Length; i++)
                sort[(strings[i][n] - 97)] += strings[i] + " ";

            int index = 0;
            for (int i = 0; i < sort.Length; i++)
            {
                if (!string.IsNullOrEmpty(sort[i]))
                {
                    string[] split = sort[i].Split(' ');

                    for (int j = 0; j < split.Length; j++)
                    {
                        for (int k = 0; k < split.Length; k++)
                        {
                            if (string.Compare(split[j], split[k]) == -1)
                            {
                                string next = split[j];
                                split[j] = split[k];
                                split[k] = next;
                            }
                        }
                    }

                    for (int j = 0; j < split.Length; j++)
                    {
                        if (!string.IsNullOrEmpty(split[j])) 
                            answer[index++] = split[j];
                    }
                }
            }

            return answer;
        }
    }
}
