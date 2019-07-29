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
        public void Kiyoshi(int rhythm)
        {
            string voice;
            if (rhythm == 0)
                voice = "ズン";
            else if (rhythm == 1)
                voice = "・";
            else
                voice = "ドコ\n";

            Console.Write(voice);
        }
    }
}
