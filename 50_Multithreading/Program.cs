using System;
using System.Threading; //for multithreading

namespace _50_Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //thread = an execution path of a program
            //         we can use multiple threads to perform,
            //         current threads running is "main" thread
            //         using System.Threading;

            Thread mainThread = Thread.CurrentThread; //get the current thread
            mainThread.Name = "Main Thread"; //set the name of the thread
            //Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp ("Timer #2"));
            thread1.Start(); //start the first thread
            thread2.Start(); //start the second thread

            //CountDown();          //call the countdown method
            //CountUp();            //call the countup method
            Console.WriteLine();
            Console.WriteLine(mainThread.Name + " is complete!");
            

            Console.ReadKey();
        }

        public static void CountDown(String name)
        {
            for (int i= 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " second");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }

        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2: " + i + " second");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}
