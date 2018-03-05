using System;

namespace B18_Ex01_01
{
    public class Ex01_01_Class
    {
        public static void Ex01_01_Start()
        {
            Console.WriteLine("Hey Ex01_01 !");
            // sequence ?! 
            int[] binaryNumbers = new int[3];
            int answer = 1;

            if (answer == 0) {
                return;
            }
            else if (answer == 1)
            {
                string[] chosenNumber;
                if (answer == 1)
                {
                    string[] binaryArrayString = { "011010000", "110100101", "110011000" }; // 12 of 1's.
                    chosenNumber = binaryArrayString;
                }
                else if (answer == 2)
                {
                    string[] Eaxmple2 = { "000100110", "000100000", "000101000" };
                    chosenNumber = Eaxmple2;
                }
                else
                {
                    string[] Eaxmple3 = { "010111101", ",011001101", "001101001" };
                    chosenNumber = Eaxmple3;
                }

                Console.WriteLine();
                binaryNumbers = InsertExampleArrays(chosenNumber);
                                
                                                                                
            }
            else if (answer == 2)
            {


                Console.WriteLine(
@"Please Enter 3 binary numbers
Any number need to be untill 9 digits
After each number press 'enter' .");
                binaryNumbers = BinaryNumbersInput();
            }

            PrintIntArray(binaryNumbers);
            Console.WriteLine("Numbers in decimal");
            int[] decimalNumbers = ConvertToDecimal(binaryNumbers);
            PrintIntArray(decimalNumbers);


            Console.WriteLine("Statcstic on the numbers:");
            Console.WriteLine("Average number is -> {0:0.00}", AverageNubmers(decimalNumbers));
            // Console.WriteLine(" SeriesDescendingCounterRecrursive with 421 == {0} " +
            //    " SeriesDescendingCounterRecrursive with 208 == {1}", SeriesDescendingCounterRecrursive(421), SeriesDescendingCounterRecrursive(208));

            Console.WriteLine("{0} Numbers are Series Descending .", SeriesDescendingCounterArray(decimalNumbers));
            Console.WriteLine("{0} Numbers are Power of 2 .", CountPow2Numbers(decimalNumbers));
            //int numberToCheck = 1001110;
            //Console.WriteLine("numberToCheck = {0} , 1's == {1}", numberToCheck, CountOnesDigitsInNumber(numberToCheck));

            byte totalDigits = 9 * 3, totalOnesDig = CountOnesDigits(binaryNumbers); // 12 of 1's.
            Console.WriteLine("There is average {0} of 1's and {1} of 0's . Total Digits {2}", totalOnesDig, (totalDigits - totalOnesDig), totalDigits);

        }

        public static void  Menu () { }  // Do Really goo Menu , An FiX! all menu promlemes and Order ALL GOOD.

        public static byte SeriesDescendingCounterArray(int[] i_NumbersAry)
        {
            byte counter = 0;
            for (int i = 0; i < i_NumbersAry.Length; i++)
            {
                if (SeriesDescendingCounterRecrursive(i_NumbersAry[i]))
                {
                    counter++;
                }

            }

            return counter;
        }

        public static bool SeriesDescendingCounterRecrursive(int i_Number)
        {
            int mod10 = i_Number % 10;
            if (i_Number / 10 == 0)
            {
                return true;
            }
            i_Number /= 10;
            if (i_Number % 10 < mod10)
            {
                return false;
            }

            return SeriesDescendingCounterRecrursive(i_Number);

        }

        public static byte CountPow2Numbers(int[] i_NumbersAry)
        {
            byte counterPow2Nums = 0;
            for (int i = 0; i < i_NumbersAry.Length; i++)
            {
                float log2Result = 0;
                if (i_NumbersAry[i] != 0)
                {
                    log2Result = (float)Math.Log(i_NumbersAry[i], 2);
                    if (log2Result == Math.Floor(log2Result))
                    {
                        counterPow2Nums++;
                    }

                }


            }

            return counterPow2Nums;
        }

        public static byte CountOnesDigits(int[] i_BinaryNumbers)
        {
            byte onesDigits = 0;
            for (int i = 0; i < i_BinaryNumbers.Length; i++)
            {
                onesDigits += CountOnesDigitsInNumber(i_BinaryNumbers[i]);
            }

            return onesDigits;
        }

        public static byte CountOnesDigitsInNumber(int i_Number)
        {
            byte onesCounter = 0;
            while (i_Number != 0)
            {
                if (i_Number % 10 == 1)
                {
                    onesCounter++;
                }
                i_Number /= 10;
            }

            return onesCounter;
        }

        public static float AverageNubmers(int[] i_NumbersAry)
        {
            float totalAverage = 0;
            for (int i = 0; i < i_NumbersAry.Length; i++)
            {
                totalAverage += i_NumbersAry[i];
            }

            totalAverage /= i_NumbersAry.Length;
            return totalAverage;
        }

        public static void PrintIntArray(int[] i_AryToPrint)
        {
            for (int i = 0; i < i_AryToPrint.Length; i++)
            {
                Console.WriteLine("Array[{0}]  = {1}", i, i_AryToPrint[i]);
            }
        }

        public static int[] BinaryNumbersInput()
        {
            int[] binaryNumbers = new int[3];
            int numbersCounter = 0;
            // StringBuilder numberInput = new StringBuilder("",9);
            // string[] checkData = { "011010000", "110100101", "110011000" }; // 12 of 1's.
            // string[] checkData = { "000100110", "000100000", "000101000" }; // 6 of 1's .
            string[] checkData = { "010111101", ",011001101", "001101001" };

            do
            {
                Console.Write("Insert now The {0} number: ", numbersCounter + 1);
                // string numberInput = Console.ReadLine();
                string numberInput = checkData[numbersCounter];

                if (CheckStringToBinary(numberInput))
                {
                    binaryNumbers[numbersCounter++] = int.Parse(numberInput);
                }
                else
                {
                    Console.WriteLine("Wrong input, please try again.");
                }


            }
            while (numbersCounter < 3);

            return binaryNumbers;
        }

        public static bool CheckStringToBinary(string i_NumberInput)
        {
            bool binaryNumber = true;
            if (i_NumberInput.Length == 9)
            {
                foreach (var item in i_NumberInput)
                {
                    if (!(item == '0' || item == '1'))
                    {
                        binaryNumber = false;
                        break;
                    }
                }
            }
            else
            {
                binaryNumber = false;
            }

            return binaryNumber;
        }

        public static int[] ConvertToDecimal(int[] i_BinaryNumbers)
        {
            int[] decimalNumbers = new int[3];
            const int baseNumber = 2;

            for (int i = 0; i < i_BinaryNumbers.Length; i++)
            {
                int binaryNumber = i_BinaryNumbers[i], totalNumber = 0, powNumber = 1;
                while (binaryNumber != 0)
                {
                    totalNumber += (powNumber * (binaryNumber % 10));
                    binaryNumber /= 10;
                    powNumber *= baseNumber;
                }

                decimalNumbers[i] = totalNumber;
                powNumber = 1;
            }

            return decimalNumbers;
        }

        public static int[] InsertExampleArrays(string[] i_BinaryArray) {
            int firstNumber = int.Parse(i_BinaryArray[0]) , secoundNumber = int.Parse(i_BinaryArray[1]), thirdNumber = int.Parse(i_BinaryArray[2]);
            int[] numbersAry = { firstNumber , secoundNumber, thirdNumber };
            return numbersAry;
        }
    }
}
