using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramDay6
{
    class PS_12
    {
        public void decimalToBinary()
        {
            Console.WriteLine("Enter a Decimal number : "); 
			int dec = Convert.ToInt32(Console.ReadLine());
			int [] binaryArray = new int[20];
			int i = 0;
			while (dec > 0)
			{
				int r = dec % 2;
				binaryArray[i++] = r;
				dec = dec / 2;
			}
            Console.WriteLine("Binary number :"); 
			for (int j = i - 1; j >= 0; j--)
                Console.Write(binaryArray[j] + ""); 
		}
    }
}

 static void Main(string[] args)
        {
            PS_12 obj11 = new PS_12();
            obj11.decimalToBinary();
        }
