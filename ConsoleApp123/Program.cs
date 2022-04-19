using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{

    public class User
    {
        public string Name;
        int Age;
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is User)) return false;
            User another = obj as User;
            return (Name == another.Name) && (Age == another.Age);
        }
        public override int GetHashCode()
        {
            return Name.Length;
        }
    }
    class Program
    {
        static void solve()
        {
            Dictionary<User, int> journal = new Dictionary<User, int>();

            var user1 = new User("Lana", 18);
            journal[user1] = 5;
            var user2 = new User("Dima", 18);
            journal[user2] = 5;
            Console.WriteLine(journal.Keys.ToList()[0].GetHashCode());
            Console.WriteLine(journal[user1]);
            user1.Name = "Dima";
            Console.WriteLine(user1.Name);

            Console.WriteLine(journal.Keys.ToList()[0].Name);
            Console.WriteLine(journal.Keys.ToList()[0].GetHashCode());
            Dictionary<string, string> dict = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                //Console.WriteLine(line.Substring(0, ind) + ";");
                dict[line[0]] = string.Join(" ", line[1..]);
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var word = Console.ReadLine();
                if (dict.ContainsKey(word))
                {
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
            string s = Console.ReadLine();
            int plus = 0,
                star = 0;
            foreach (var letter in s)
            {
                if (letter == '+') plus++;
                if (letter == '*') star++;
            }
            Console.WriteLine($"Символ + встречается {plus} раз");
            Console.WriteLine($"Символ * встречается {star} раз");
        }
    }
}
