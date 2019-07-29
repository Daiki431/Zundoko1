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

        public int count;
        public void ZundokoBand(int speed)
        {
            Singer singer = new Singer();
            Listener listener = new Listener();
            Random rand = new Random();

            int rhythm = 0;
            int tail = 1;

            while (true)
            {
                rhythm = rand.Next(3);
                singer.Kiyoshi(rhythm);

                switch (rhythm){
                    case 0:
                        if (count < 5 && tail == 1 && (count == 0 || count >= 2))
                            count++;
                        else{
                            count = 0;
                            tail = 0;
                        }
                        break;
                    case 1:
                        if (count == 1)
                            count++;
                        else{
                            count = 0;
                            tail = 0;
                        }
                        break;
                    case 2:
                        if (count == 5)
                            count++;
                        else{
                            count = 0;
                            tail = 1;
                        }
                        break;                       
                }

                listener.ZundokoListener(count);
                if (count == 6)
                    break;
                Thread.Sleep(speed);
            }
        }
    }
}
