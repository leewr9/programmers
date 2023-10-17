using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.KAKAO_BLIND_RECRUITMENT
{
    internal class 신고_결과_받기
    {
        public int[] solution(string[] id_list, string[] report, int k)
        {
            int[][] check = new int[id_list.Length][];
            int[] answer = new int[id_list.Length];

            for (int i = 0; i < report.Length; i++)
            {
                string[] id_report = report[i].Split(' ');
                int user = -1;
                int rep = -1;

                for (int j = 0; j < id_list.Length; j++)
                {
                    if (check[j] == null)
                        check[j] = new int[id_list.Length + 1];

                    if (id_report[0] == id_list[j])
                    {
                        rep = j;

                        if (user > -1)
                        {
                            if (check[user][rep] == 0)
                                check[user][id_list.Length]++;
                            check[user][rep] = 1;
                            break;
                        }
                    }

                    if (id_report[1] == id_list[j])
                    {
                        user = j;

                        if (rep > -1)
                        {
                            if (check[user][rep] == 0)
                                check[user][id_list.Length]++;
                            check[user][rep] = 1;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < check.Length; i++)
            {
                if (check[i] != null && check[i][id_list.Length] >= k)
                {
                    for(int j = 0; j < check[i].Length - 1; j++)
                    {
                        if (check[i][j] == 1)
                            answer[j]++;
                    }
                }
            }

            return answer;
        }
    }
}
