using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static string isAnagram(string string1, string string2)
        {
            char[] s1 = ((string1.Replace(" ", "")).ToCharArray());
            char[] s2 = ((string2.Replace(" ", "")).ToCharArray());
            Array.Sort(s1);
            Array.Sort(s2);
            if (s1.SequenceEqual(s2))
                return "Yes";
            else
                return "No";
        }
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            Console.WriteLine(isAnagram(string1, string2));
        }
    }
}
