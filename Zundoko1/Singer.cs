using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundoko1
{
    class Singer
    {
        Random r = new Random();
        //「ズン」、「ドコ」、「・」をランダムで出力
        public int ZundokoSinger()
        {
            int rand = r.Next(3);

            if (rand == 0)
                Console.Write("ズン");
            else if (rand == 1)
                Console.WriteLine("ドコ");
            else
                Console.Write("・");


            return rand;
        }
    }
}
