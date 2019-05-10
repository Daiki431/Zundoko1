using System;

namespace Zundoko1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            while (true)
            {
                int[] j = new int[10000];

                for (int n = 0; n <= 10000; n++)
                {
                    j[n] = r.Next(2);
                    if (j[n] == 0)
                        Console.Write("ズン");
                    else
                        Console.WriteLine("ドコ");
                    if (n>=4&&j[n - 4] == 0 && j[n - 3] == 0 && j[n - 2] == 0 && j[n - 1] == 0 && j[n] == 1)
                    {
                        if (n >= 5 && j[n - 5] == 1)
                            break;
                        if (n == 4)
                            break;
                    }
                }
                Console.WriteLine("キ・ヨ・シ！");
                Console.WriteLine("------------------------------");
                Console.ReadLine();
            }
        }
    }
}
