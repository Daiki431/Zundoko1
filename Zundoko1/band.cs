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
        //Singerに指示する
        public void ZundokoBand()
        {
            Singer zundokoSinger = new Singer();
            int[] count = new int[100000];
            int f = 0;

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
                Thread.Sleep(0);
            }
            Listener listener = new Listener();
            listener.ZundokoListener();
        }
        
    }
}
