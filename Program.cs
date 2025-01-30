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
            int[] number = new int[5];
            int pair = 0;
            int ThreeFour = 0;
            for (int i = 0; i < card.Length; i++)
            {
                while(true)
                {
                    bool parse;
                    string input;
                    Console.WriteLine("1～4の数字を入力してね");
                    input = Console.ReadLine();
                   parse = int.TryParse(input,out card[i]);
                    

                    if(card[i]>=1&&card[i]<=4&&parse==true)
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
                if(number[card[i]]>=3)
                {
                    ThreeFour = number[card[i]];
                }
            }

            if(pair >= 1)
            {
                if (pair >= 2)
                {
                    Console.WriteLine($"ツーペア");
                }
                else if(ThreeFour==3)
                {
                    Console.WriteLine($"スリーカード");
                }
                else if (ThreeFour == 4)
                {
                    Console.WriteLine($"フォーカード");
                }
                else
                {
                    Console.WriteLine($"ワンペア");
                }
            }
            else
            {
                Console.WriteLine($"ノーペア");
            }
                Console.ReadLine();
        }
    }
}
