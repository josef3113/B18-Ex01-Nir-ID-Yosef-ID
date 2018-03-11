using System;
using System.Text;

namespace B18_Ex01_01
{
    public class Ex01_01_Class
    {
        public static void Ex01_01_Start()
        {
            Console.WriteLine("Hey, Ex01_01 !");
            Console.WriteLine("Insert 0 for insert your own numbers, insert everything else for examples data.");
            string answerInput = Console.ReadLine();
            bool answer = byte.TryParse(answerInput, out byte isZero) && isZero == 0 ? true : false;
            if (answer)
            {
                UserInput();
            }
            else
            {
                ExamplesData();
            }
        }

        public static void StaticsNumbers(string[] i_NumbersInString)
        {
            StringBuilder stringBuilder = new StringBuilder("String Numbers are -> ", 100);
            int[] binaryNumbers = new int[i_NumbersInString.Length];
            for (int i = 0; i < i_NumbersInString.Length; i++)
            {
                stringBuilder.Append(string.Format(", {0}", i_NumbersInString[i]));
                binaryNumbers[i] = int.Parse(i_NumbersInString[i]);
            }

            Console.WriteLine(stringBuilder);
            int[] decimalNumbers = ConvertToDecimal(binaryNumbers);
            Console.WriteLine(IntArrayToString(decimalNumbers));

            Console.WriteLine("Statcstic on the numbers:");
            Console.WriteLine("Average number is -> {0:0.00}", AverageNubmers(decimalNumbers));
            Console.WriteLine("{0} Numbers are sequence decreasing .", SequenceDecreasingCounterArray(decimalNumbers));
            Console.WriteLine("{0} Numbers are Power of 2 .", CountPow2Numbers(decimalNumbers));
            byte totalDigits = Convert.ToByte(binaryNumbers.Length * 9), totalOnesDig = CountOnesDigits(binaryNumbers);
            Console.WriteLine("There are {0} of 1's and {1} of 0's . Total Digits {2}"
                              , totalOnesDig, (totalDigits - totalOnesDig), totalDigits);

        }

        public static void UserInput()
        {
            byte counter3Input = 3, i = 0;
            string[] binaryNumbersString = new string[counter3Input];
            Console.WriteLine(
@"Please Enter 3 binary numbers
Any number need to be untill 9 digits
After each number press 'enter' .");
            while (i < counter3Input)
            {
                Console.WriteLine("Insert binary number (count numbers is {0})", i + 1);
                string binaryInput = Console.ReadLine();
                if (CheckStringToBinary(binaryInput))
                {
                    binaryNumbersString[i++] = binaryInput;
                }
                else
                {
                    Console.WriteLine("Wrong input . Try again.");
                }
            }

            StaticsNumbers(binaryNumbersString);
        }

        public static void ExamplesData()
        {
            string[][] ExamplesStringsBinNumbers = new string[][]
                { new string[] { "011010000", "110100101", "110011000" },
                  new string[] { "000100110", "000100000", "000101000" },
                  new string[] { "010111101", "011001101", "001101001" } };

            for (int i = 0; i < ExamplesStringsBinNumbers.Length; i++)
            {
                StaticsNumbers(ExamplesStringsBinNumbers[i]);
            }

        }

        public static byte SequenceDecreasingCounterArray(int[] i_NumbersAry)
        {
            byte counter = 0;
            for (int i = 0; i < i_NumbersAry.Length; i++)
            {
                if (SequenceDecreasingCounterRecrursive(i_NumbersAry[i]))
                {
                    counter++;
                }

            }

            return counter;
        }

        public static bool SequenceDecreasingCounterRecrursive(int i_Number)
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

            return SequenceDecreasingCounterRecrursive(i_Number);
        }

        public static byte CountPow2Numbers(int[] i_NumbersAry)
        {
            byte counterPow2Nums = 0;
            for (int i = 0; i < i_NumbersAry.Length; i++)
            {

                if (IsPowOf2(i_NumbersAry[i]) && i_NumbersAry[i] != 0)
                {
                    counterPow2Nums++;
                }
            }

            return counterPow2Nums;
        }

        public static bool IsPowOf2(int i_Number)
        {
            bool answer = false;
            float log2Number = (float)Math.Log(i_Number, 2);
            if (log2Number == Math.Floor(log2Number)) // if will be mod so its not pow of 2;
            {
                answer = true;
            }

            return answer;
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

        public static string IntArrayToString(int[] i_AryToString)
        {
            StringBuilder stringBuilder = new StringBuilder("Numbers are -> ", 50);
            for (int i = 0; i < i_AryToString.Length; i++)
            {
                stringBuilder.AppendFormat(", {0}", i_AryToString[i]);
            }

            return stringBuilder.ToString();
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
            int[] decimalNumbers = new int[i_BinaryNumbers.Length];
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

    }
}
