using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramDay6
{
    class PS_2
    {
        public void perfectNumber()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
			      int sum = 0;
			      for (int i = 1; i < num; i++)
			      {
				        if (num % i == 0)
					      sum = sum + i;
			        }
			        if (sum == num)
			          {
                  Console.WriteLine("Perfect Number"); 
			          }
			        else
			         {
                Console.WriteLine("Not an Perfect Number");
			         }		
		        }
       }
}

static void Main(string[] args)
        {
            PS_2 obj1 = new PS_2();
            obj1.perfectNumber();
        }
