﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv._1.연습문제
{
    internal class 직사각형_별찍기
    {
        public static void Mains()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("{0}", a + b);
        }
    }
}
