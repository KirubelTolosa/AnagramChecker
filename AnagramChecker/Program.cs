using System;
using System.Collections.Generic;

namespace AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("agrmana", "anagram") ? "Anagram Strings!" : "Not Anagrams!");
        }
        static bool IsAnagram(string strA, string strB)
        {
            bool isAnagram = false;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            bool keyExists = true;
            if (strA.Length == strB.Length)
            {
                foreach(char x in strA)
                {
                    if (!dict.ContainsKey(x))
                    {
                        dict.Add(x, 1);
                    }
                    else
                    {
                        dict[x] = dict[x] + 1;
                        int test = dict[x];
                    }
                }
                foreach (char y in strB)
                {
                    if (dict.ContainsKey(y))
                    {
                        dict[y]--;
                        int a = dict[y];
                    }
                    else
                    {
                        keyExists = false;
                        break;
                    }
                }
                if (keyExists == true)
                {
                    foreach (KeyValuePair<char, int> x in dict)
                    {
                        if (x.Value != 0)
                        {
                            isAnagram = false;
                            break;
                        }
                        else
                        {
                            isAnagram = true;
                        }
                    }
                }
            }
            return isAnagram;
        }
    }   
}
