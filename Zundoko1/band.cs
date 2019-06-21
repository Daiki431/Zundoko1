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
            Singer singer = new Singer();
            Listener listener = new Listener();
            Random rand = new Random();

            int rhythm = 0;
            int count = 0;
            int tail = 1;

            while (true)
            {
                rhythm = rand.Next(3);
                singer.Kiyoshi(rhythm);
                switch (rhythm)
                {
                    case 0://zun
                        if (count < 5 && tail == 1 && (count == 0 || count >= 2))
                            count++;
                        else
                        {
                            count = 0;
                            tail = 0;
                        }
                        break;
                    case 1://・
                        if (count == 1)
                            count++;
                        else
                        {
                            count = 0;
                            tail = 0;
                        }
                        break;
                    case 2://doko
                        if (count == 5)
                            count++;
                        else
                        {
                            count = 0;
                            tail = 1;
                        }
                        break;
                }
                if (count == 6)
                {
                    listener.ZundokoListener();
                    break;
                }
            }
        }
    }
}
