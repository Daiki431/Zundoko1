using System;

namespace Zundoko1
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = 0;
            while (true){
                Console.WriteLine("スピードを入力してください。(ms)");
                try{
                    speed = int.Parse(Console.ReadLine());
                    break;
                }
                catch { }
            }          
            Band band = new Band();
            band.ZundokoBand(speed);  
        }
    }
}
