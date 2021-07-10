using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramDay6
{
    class PS_4
    {
        public void reverseNumber()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Reverse of " +num+ " is :");
            int reverse = 0;
            String s = "";
            while (num != 0)
            {
                int pick_last = num % 10;
                s = s + Convert.ToInt32(pick_last);
                num = num / 10;
            }
            Console.WriteLine(s);
        }
    }
}

static void Main(string[] args)
        {
            PS_4 obj3 = new PS_4();
            obj3.reverseNumber();
        }
