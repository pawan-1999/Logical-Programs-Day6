using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramDay6
{
    class PS_7
    {
        public void amount ()
        {
            Console.WriteLine("Enter the amount :");
            int amount = Convert.ToInt32(Console.ReadLine());
            vendingMachine(amount);
        }
        public static void vendingMachine( int amount )
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[7];

            for (int i = 0; i < 7; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }

            Console.WriteLine("Currency Count ->");
            int noOfNotes = 0;
            for (int i = 0; i < 7; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " +noteCounter[i]);
                    noOfNotes += noteCounter[i];
                }
            }
            Console.WriteLine("Minimum number of notes : "+noOfNotes);
        }
    }
}

static void Main(string[] args)
        {
            PS_7 obj6 = new PS_7();
            obj6.amount();
        }
