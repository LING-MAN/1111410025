using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1111410025_徐菱曼031
{
    class Program
    {
        static int[]Char(string[] words, char x)
        {
            List<int> indices = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    indices.Add(i);
                }
            }

            if (indices.Count == 0)
            {
                return null; 
            }

            return indices.ToArray();
        }

        static void Main(string[] args)
        {
            string[] words = { "abc","bcd","aaaa","cbc" };
            char x = 'z';

            int[] result = Char(words, x);

            if (result == null)
            {
                Console.WriteLine("未出現在任何單字'" + x + "' null。");
            }
            else
            {
                Console.WriteLine("出現在'" + x + "':");
                foreach (int index in result)
                {
                    Console.WriteLine(index);
                }
                Console.Read();
            }
        }
    }
}