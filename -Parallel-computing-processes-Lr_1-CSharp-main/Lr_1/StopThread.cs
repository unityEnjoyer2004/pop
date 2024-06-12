using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lr_1
{
    public class StopThread
    {
        private bool canStop = false;

        public void Run()
        {
            try
            {
                Thread.Sleep(3 * 1000);
            }
            catch(ThreadInterruptedException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            canStop = true;
        }
        public bool IsCanStop()
        {
            return canStop;
        }
    }
}
