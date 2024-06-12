using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr_1
{
    public class SumThread
    {
        private int id;
        private StopThread stopThread;
        private int step;

        public SumThread(int id, StopThread stopThread, int step)
        {
            this.id = id;
            this.stopThread = stopThread;
            this.step = step;
        }

        public void Run()
        {
            long sum = 0;
            int additions = 0;
            bool isStop = false;
            do
            {
                sum+= additions * step;
                additions++;
                isStop = stopThread.IsCanStop();
            } while (!isStop);
            Console.WriteLine($"Thread {id} - Sum: {sum} - Additions: {additions}");
        }
    }
}
