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

            if (rhythm == 0)
                Console.Write("ズン");
            else if (rhythm == 1)
                Console.Write("・");
            else
                Console.WriteLine("ドコ");
        }
    }
}
