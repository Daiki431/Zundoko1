using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundoko1
{
    class Band
    {
        static int[] count=new int[100000];
        public Band()
        {
            int i = 0;
            int f = 0;
            Singer zundokoSinger = new Singer();
            while (true)
            {
                count[f] = zundokoSinger.Song();
                if (count[f] == 0)
                    Console.Write("ズン");
                else if (count[f] == 1)
                    Console.WriteLine("ドコ");
                else
                    Console.Write("・");

                if (f >= 5 && count[f - 5] == 0 && count[f - 4] == 2 && count[f - 3] == 0 && count[f - 2] == 0 && count[f - 1] == 0 && count[f] == 1)
                {
                    if (f >= 6 && count[f - 6] == 1)
                        break;
                    if (f == 5)
                        break;
                }
                f++;
            }
        }
        
    }

    class Singer
    {
        Random r = new Random();

        public int Song()
        {
            return r.Next(3);
        }
    }
}
