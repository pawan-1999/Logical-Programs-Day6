using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramDay6
{
    class PS_8
        {
            public void checkDayForADate()
            {
                int yr, mn, dt;

                Console.Write(" Find the day for a given date :\n ");
                Console.Write("------------------------------------\n");

                Console.Write(" Input the Day : ");
                dt = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Input the Month : ");
                mn = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Input the Year : ");
                yr = Convert.ToInt32(Console.ReadLine());
                
                //using DateTime predefined method 
                //storing the date in local variable d and printing it using ToString pre defined method 
                DateTime d = new DateTime(yr, mn, dt);
                Console.WriteLine(" The formatted Date is : "+d.ToString("dd/MM/yyyy"));
                
                //taking  pp local variable and storing date in it 
                DateTime pp;
                pp = DayOfWeek(d);
                Console.WriteLine(" The day for the date is : "+pp.DayOfWeek);
            }
            public static DateTime DayOfWeek(DateTime dt)
            {
                DateTime ss = new DateTime(dt.Year, dt.Month, dt.Day);
                return ss;
            }
        }
    }

static void Main(string[] args)
        {
            PS_8 obj7 = new PS_8();
            obj7.checkDayForADate();
        }
