using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundoko1
{
    class band
    {
        static void Band()
        {
            Random r = new Random();
            singer zundokosinger;
            zundokosinger = new singer();
            
        }
        
    }

    class singer
    {
        public void Song(int i)
        {
            if (i == 0)
                Console.Write("ズン");
            else if (i == 1)
                Console.Write("ドコ");
            else
                Console.Write("・");
        }
    }
}
