using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zundoko1
{
    class Band
    {
        public int[] count = new int[10];
        public int i = 0;
        //Singerに指示する
        public void ZundokoBand()
        {
            Singer singer = new Singer();
            Listener listener = new Listener();


            while (true)
            {
                if (i > 9)
                {
                    count[0] = count[i - 5];
                    count[1] = count[i - 4];
                    count[2] = count[i - 3];
                    count[3] = count[i - 2];
                    count[4] = count[i - 1];
                    i = 5;
                }

                count[i] = singer.Kiyoshi();

                if (i >= 5 && count[i - 5] == 0 && count[i - 4] == 2 && count[i - 3] == 0 && count[i - 2] == 0 && count[i - 1] == 0 && count[i] == 1)
                {
                    if (i >= 6 && count[i - 6] == 1)
                        break;
                    if (i == 5)
                        break;
                }
                i++;
                Thread.Sleep(1);
            }
            listener.ZundokoListener();
        }
        
    }
}
