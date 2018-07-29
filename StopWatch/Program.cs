using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace stopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 1; i <=10 ; i++)
            {
                for (int j = 0; j <i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int a = 0;
            int b = 1;
            

            for (int i = 1; i <= 1; i++)
            {
                Console.Write(a + ",");
                Console.Write(b + ",");
            }
            for (int i = 1; i <=10; i++)
            {
                int toplam = a + b;
                a = b;
                b = toplam;
                Console.Write(toplam+",");
            }
            Console.WriteLine();
            watch.Stop();
            Console.WriteLine("Stop Süresi: "+watch.Elapsed.Milliseconds);

            Console.ReadLine();
        }
    }
}
