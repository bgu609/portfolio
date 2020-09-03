using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingLock
{
    class Counter
    {
        const int LOOP_COUNT = 1_000;

        readonly object thisLock;

        public int count { get; set; }

        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopcount = LOOP_COUNT;
            while(loopcount-- > 0)
            {
                lock(thisLock)
                {
                    count++;
                    Console.WriteLine(count);
                }
                Thread.Sleep(1);
            }
        }

        public void Decrease()
        {
            int loopcount = LOOP_COUNT;
            while (loopcount-- > 0)
            {
                lock (thisLock)
                {
                    count--;
                    Console.WriteLine(count);
                }
                Thread.Sleep(1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread increase = new Thread(new ThreadStart(counter.Increase));
            Thread decrease = new Thread(new ThreadStart(counter.Decrease));

            increase.Start();
            decrease.Start();

            increase.Join();
            decrease.Join();

            Console.WriteLine(counter.count);
        }
    }
}
