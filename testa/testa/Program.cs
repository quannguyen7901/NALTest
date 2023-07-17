using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Result
    {
        public static int solution(string a)
        {
            int same = 0;
            a = a.ToLower();
            if (a.Length <= 0 && a != "w")
            {
                return same;
            }
            else
            {
                do
                {
                    if (a.IndexOf("aw") != -1)
                    {
                        same++;
                        a = a.Remove(a.IndexOf("aw"), 2);
                    }
                    else if (a.IndexOf("aa") != -1)
                    {
                        same++;
                        a = a.Remove(a.IndexOf("aa"), 2);
                    }
                    else if (a.IndexOf("dd") != -1)
                    {
                        same++;
                        a = a.Remove(a.IndexOf("dd"), 2);
                    }
                    else if (a.IndexOf("ee") != -1)
                    {
                        same++;
                        a = a.Remove(a.IndexOf("ee"), 2);
                    }
                    else if (a.IndexOf("oo") != -1)
                    {
                        same++;
                        a = a.Remove(a.IndexOf("oo"), 2);
                    }
                    else if (a.IndexOf("ow") != -1)
                    {
                        same++;
                        a = a.Remove(a.IndexOf("ow"), 2);
                    }
                    else if (a.IndexOf("w") != -1)
                    {
                        same++;
                        a = a.Remove(a.IndexOf("w"), 1);
                    }
                    else
                    {
                        return same;
                    }

                    if (a.Length == 0)
                    {
                        return same;
                    }
                }
                while (true);
            }
        }

    }
    class Solution
    {
        static void Main(string[] args)
        {
            string s1 = "hfdawhwhcoomdd";
            int result = Result.solution(s1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}