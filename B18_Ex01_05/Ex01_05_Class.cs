using System;

namespace B18_Ex01_05
{
    public class Ex01_05_Class
    {
        public static void Ex01_05_Start()
        {
            Console.WriteLine("Hey, Ex01_05 !");
            uint number = InputNumber();                       
            Console.WriteLine("Statisc on the number:");
            Console.WriteLine("Biggest digit in number = {0}", BiggestDigit(number));
            Console.WriteLine("Smallest digit in number = {0}", SmallestDigit(number));
            Console.WriteLine("There are {0} even digit in number", EvenDigits(number));
            Console.WriteLine("There are {0} digits that samllest then the last digit ({1}).", SmallThenLastDigit(number) , number % 10);
            
        }

        public static byte BiggestDigit(uint i_Number)
        {
            byte maxDig = (byte)(i_Number % 10);
            i_Number /= 10;
            while (i_Number != 0)
            {
                maxDig = (i_Number % 10) > maxDig ? (byte)(i_Number % 10) : maxDig;
                i_Number /= 10;
            }

            return maxDig;
        }

        public static byte SmallestDigit(uint i_Number)
        {
            byte minDig = (byte)(i_Number % 10);
            i_Number /= 10;
            while (i_Number != 0)
            {
                minDig = (i_Number % 10) < minDig ? (byte)(i_Number % 10) : minDig;
                i_Number /= 10;
            }

            return minDig;
        }

        public static byte EvenDigits(uint i_Number)
        {
            byte counterEvenDigit = 0;
            while (i_Number != 0)
            {
                byte lastDigit = (byte)(i_Number % 10);
                if (lastDigit % 2 == 0)
                {
                    counterEvenDigit++;
                }
                i_Number /= 10;
            }

            return counterEvenDigit;
        }

        public static byte SmallThenLastDigit(uint i_Number)
        {
            byte lastDigit = (byte)(i_Number % 10) , counterSmallThenLastDig = 0;
            i_Number /= 10;
            while (i_Number != 0) {
                if ((byte)(i_Number % 10) < lastDigit) {
                    counterSmallThenLastDig++;
                }

                i_Number /= 10;
            }

            Console.WriteLine("Last Dig -> {0} , Counter -> {1}",lastDigit,counterSmallThenLastDig);
            return counterSmallThenLastDig;

        }

        public static uint InputNumber()
        {
            uint number = 0;
            bool quit = false;
            while (!quit)
            {
                Console.Write("Please insert your number here (8 Digit unsignd number) : ");
                string inputNumber = Console.ReadLine();
                if (uint.TryParse(inputNumber, out number) && inputNumber.Length == 8)
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Wrong input! Try again.");
                }
            }

            return number;
        }
    }
}
