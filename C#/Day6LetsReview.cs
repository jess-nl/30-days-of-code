﻿using System;

class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();

            for (int j = 0; j < s.Length; j++)
            {
                if (j % 2 == 0)
                    Console.Write(s[j]);
            }

            Console.Write(" ");

            for (int j = 0; j < s.Length; j++)
            {
                if (j % 2 != 0)
                    Console.Write(s[j]);
            }

            Console.Write("\n");
        }
    }
}