using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sanbai, gobai;

            n = int.Parse(Console.ReadLine().Trim());

            if (0 < n)
            {
                if (n < 101)
                {
                    for (int cnt = 1; cnt <= n; cnt++)
                    {
                        sanbai = 0;
                        gobai = 0;

                        sanbai = cnt % 3;
                        gobai = cnt % 5;

                        // 3かつ5の倍数
                        if (sanbai == 0 && gobai == 0)
                        {
                            Console.WriteLine("Fizz Buzz");
                        }
                        else if (sanbai == 0)
                        {
                            // 3の倍数
                            Console.WriteLine("Fizz");
                        }
                        else if (gobai == 0)
                        {
                            // 5の倍数
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            // それ以外
                            Console.WriteLine(cnt);
                        }
                    }
                    // 改行
                    Console.WriteLine("\n");
                    //Console.WriteLine("改行確認");
                } else
                {
                    Console.WriteLine("error(入力ミス)");
                }
            } else
            {
                Console.WriteLine("error(入力ミス)");
            }
        }
    }
}
