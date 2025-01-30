using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] card = new int[4];
            int[] number = new int[4];
            int pair = 0;
            for (int i = 0; i < card.Length; i++)
            {
                while(true)
                {
                    Console.WriteLine("1～4の数字を入力してね");
                    card[i]=int.Parse(Console.ReadLine());

                    if(card[i]>=1&&card[i]<=4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("無効な値です");
                        Console.ReadLine();
                    }

                }
            }

            for (int i = 0; i < card.Length; i++)
            {
                Console.Write($"{card[i]}");
            }

            for (int i = 0; i < card.Length; i++)
            {
                number[card[i]]++;
                if (number[card[i]] == 2)
                {
                    pair++;
                }
            }



            Console.WriteLine($"ペア数{pair}");

                Console.ReadLine();
        }
    }
}
