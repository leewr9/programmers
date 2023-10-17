using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.Summer_Winter_Coding
{
    internal class 소수_만들기
    {
        public int solution(int[] nums)
        {
            int answer = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for(int k = j + 1; k < nums.Length; k++)
                    {
                        int num = nums[i] + nums[j] + nums[k];
                        bool frime = true;

                        for (int l = 2; l < num; l++)
                        {
                            if (num % k == 0)
                            {
                                frime = false;
                                break;
                            }

                        }
                        if (frime)
                            answer++;
                    }
                }
            }

            return answer;
        }
    }
}
