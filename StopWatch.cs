using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace LogicalProgramDay6
{
    public class PS_6
    {
        public void stopWatch()
        {
            string start = "";
            string end = "";
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Hit ENTER to start the Stopwatch:");
            start = Console.ReadLine();

            if (start.Equals(""))
            {
                DateTime S = DateTime.Now;
                Console.WriteLine("Start Time: " + S);
                stopwatch.Start();

            }

            Console.WriteLine("Hit ENTER to stop the Stopwatch:");
            end = Console.ReadLine();

            if (end.Equals(""))
            {
                DateTime E = DateTime.Now;
                Console.WriteLine("End Time:" + E);
                stopwatch.Stop();
            }

            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Elapsed Time is  : " + ts);
        }

    }

}

static void Main(string[] args)
        {
            PS_6 obj5 = new PS_6();
            obj5.stopWatch();
        }
