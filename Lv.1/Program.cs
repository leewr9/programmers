using Lv._1.연습문제;
using Lv._1.완전탐색;
using Lv._1.월간_코드_챌린지;
using Lv._1.정렬;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new 문자열_내_마음대로_정렬하기().solution(new string[] { "sun", "bed", "car" }, 1);
            new 문자열_내_마음대로_정렬하기().solution(new string[] { "adce", "bbcd", "abcz", "abcf", "cdx" }, 2);
            Console.ReadLine();
        }
    }
}
