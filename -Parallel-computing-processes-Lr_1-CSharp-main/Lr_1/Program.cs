using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lr_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StopThread stopThread = new StopThread();

            for(int i = 1;i<=10;i++)
            {
                SumThread sumThread = new SumThread(i, stopThread,1);
                Thread thread = new Thread(new ThreadStart(sumThread.Run));
                thread.Start();
            }

            Thread stopThr=new Thread(new ThreadStart(stopThread.Run));
            stopThr.Start();

            Console.ReadKey();
        }
    }
}
