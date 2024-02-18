using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольная_работа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] someArr = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };
            string[] answer = new string[someArr.Length];
            int i = 0;
            foreach (string three in someArr)
            {
                if (three.Length <= 3)
                    answer[i] = three;
                i++;
            }
            answer = answer.Where(x => x != null).ToArray();
            Console.WriteLine(String.Join(",", answer));
        }
    }
}
