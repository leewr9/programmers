using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._2.Summer_Winter_Coding
{
    internal class 스킬트리
    {
        public int solution(string skill, string[] skill_trees)
        {
            int answer = 0;

            for (int i = 0; i < skill_trees.Length; i++)
            {
                int count = 0;
                for (int j = 0;  j < skill_trees[i].Length; j++)
                {
                    int index = skill.IndexOf(skill_trees[i][j]);
                    if (index > -1 )
                    {
                        if (index == count)
                            count++;
                        else
                        {
                            count = -1;
                            break;
                        }
                    }
                }

                if (count > -1)
                    answer++;
            }

            return answer;
        }
    }
}
