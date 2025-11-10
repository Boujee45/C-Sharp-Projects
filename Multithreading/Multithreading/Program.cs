using System;
using System.Threading;
namespace Threader
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Thread mainThread = Thread.CurrentThread;

            mainThread.Name = "Main Thread";
            CountDown();
            CountUp();
            Console.ReadKey();
        }
        public static void CountDown()
        {
            for(int i = 10;i >= 0;i--)
            {
                Console.WriteLine("Timer #1 : " + i + "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nTimer #1 is complete!\n");
        }
        public static void CountUp()
        {
            for(int i = 0; i <= 10;i++)
            {
                Console.WriteLine("Timer #2 " + i + "seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nTimer #2 is complete!");
        }
    }
}