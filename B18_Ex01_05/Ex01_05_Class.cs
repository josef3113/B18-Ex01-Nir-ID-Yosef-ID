using System;

namespace B18_Ex01_05
{
    public class Ex01_05_Class
    {
        public static void Ex01_05_Start()
        {
            Console.WriteLine("Hey Ex01_05 !");
            //int number = InputNumber();
            int number = 73562545;
            Console.WriteLine("Number -> {0}", number);
            Console.WriteLine("Statisc on the number:");
            Console.WriteLine("Biggest digit in number = {0}", BiggestDigit(number));
            Console.WriteLine("Smallest digit in number = {0}", SmallestDigit(number));
            Console.WriteLine("There are {0} even digit in number", EvenDigits(number));
            Console.WriteLine("How much small digits then the last digit ({0}) , answer: {1}", number % 10, SmallThenAhdot(number));

        }

        public static byte BiggestDigit(int i_Number)
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

        public static byte SmallestDigit(int i_Number)
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

        public static byte EvenDigits(int i_Number)
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

        public static byte SmallThenAhdot(int i_Number) // NEED to find better name the the func . replace the 'Ahdot' !!
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

        public static int InputNumber()
        {
            int number = 0;
            bool quit = false;
            while (!quit)
            {
                Console.Write("Please insert your number here: ");
                string inputNumber = Console.ReadLine();
                if (int.TryParse(inputNumber, out number) && inputNumber.Length == 8)
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
