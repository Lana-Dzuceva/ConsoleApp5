using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void solve()
        {
            
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                //Console.WriteLine(line.Substring(0, ind) + ";");
                dict[line[0..1]] = line.Substring(ind + 1);
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var word = Console.ReadLine();
                if (dict.ContainsKey(word)) {
                    Console.WriteLine(dict[word]);
                }
                else
                {
                    Console.WriteLine("Нет в словаре");
                }
            }

        }
        static void Main(string[] args)
        {
            solve();
        }
    }
}
