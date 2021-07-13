using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramDay6
{
    class PS_11
    {
        public void sqrtNewtonsMethod()
        {
            Console.WriteLine("Enter the value of c :");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine(t);
        }
    }
}

 static void Main(string[] args)
        {
            PS_11 obj10 = new PS_11();
            obj10.sqrtNewtonsMethod();
        }
