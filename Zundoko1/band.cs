using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundoko1
{
    class Band
    {
        public int[] count = new int[100000];
        public int f = 0;
        public void ZundokoBand()
        {
            Singer zundokoSinger = new Singer();
            while (true)
            {
                count[f] = zundokoSinger.ZundokoSinger();
                

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
        //「ズン」、「ドコ」、「・」をランダムで出力
        public int ZundokoSinger()
        {
            Random r = new Random();
            int rand = r.Next(3);
            Band band = new Band();

            band.count[band.f] = rand;

            if (band.count[band.f] == 0)
                Console.Write("ズン");
            else if (band.count[band.f] == 1)
                Console.WriteLine("ドコ");
            else
                Console.Write("・");
            return rand;
        }
    }
}
