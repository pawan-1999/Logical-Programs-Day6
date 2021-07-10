using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramDay6
{
    class PS_1
    {
        public void fibonacciSeries()
        {
            Console.WriteLine("Enter the limit : ");
            int lim = Convert.ToInt32(Console.ReadLine());
			if (lim > 0)
			{
				int y = 0, z = 1, s;
                Console.Write("Fibonacci Series : " + y + "  " + z + "  ");
				while (z <= lim)
				{
					s = y + z;
					y = z;
					z = s;
					if (z <= lim)
                        Console.Write(z + "  "); 
				}
			}
			else
                Console.WriteLine("Wrong Input"); 
		}
	}
}

static void Main(string[] args)
        {
            PS_1 obj = new PS_1();
            obj.fibonacciSeries();
        }
