using System;
using System.Diagnostics;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing();
            UnBoxing();
        }

        private static void Boxing()
        {
            Stopwatch stopwatch = new Stopwatch();
            int j = 15;
            stopwatch.Start();

            for (int i = 0; i < 100000; i++)
            {
                object k = j;
                Console.WriteLine(k);
            }

            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
            timeSpan.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        private static void UnBoxing()
        {
            Stopwatch stopwatch = new Stopwatch();

            object j = 123;
            int k;

            stopwatch.Start();

            for (int i = 0; i < 100000; i++)
            {
                k = (int)j;
                Console.WriteLine(k);
            }

            stopwatch.Stop();

            TimeSpan timeSpan = stopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
            timeSpan.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
