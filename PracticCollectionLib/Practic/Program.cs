using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> word = new Dictionary<string, int>();

            var chtoYgodno = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном  чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            int number = 0;
            bool cheak = true;

            foreach (var j in chtoYgodno.Split())
            {
                foreach (var n in word)
                {
                    if (j == n.Key)
                    {
                        cheak = false;
                    }
                }
                if (cheak)
                {
                    foreach (var i in chtoYgodno.Split())
                    {
                        if (j == i)
                        {
                            number++;
                        }
                    }
                    word.Add(j, number);
                    number = 0;
                    cheak = true;
                }
            }


            foreach (var i in word)
            {
                Console.WriteLine($"{i.Key}\t\t\t{i.Value}");
            }


        }
    }
}
