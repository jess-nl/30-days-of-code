using System.Collections.Generic;
using System;

class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        string name;

        Dictionary<string, int> phoneBook = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            var pair = Console.ReadLine().Split(' ');
            phoneBook[pair[0]] = Convert.ToInt32(pair[1]); // or phoneBook.Add(pair[0], Convert.ToInt32(pair[1]));
        }

        while ((name = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(name))
                Console.WriteLine($"{name}={phoneBook[name]}");
            else
                Console.WriteLine("Not found");
        }
    }
}