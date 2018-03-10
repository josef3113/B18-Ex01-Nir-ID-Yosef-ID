using System;

namespace B18_Ex01_03
{
    public class Ex01_03_Class
    {
        public static void Ex01_03_Start()
        {
            Console.WriteLine("Hey, Ex01_03 !");
            Console.WriteLine("Insert 0 for insert hight, insert everything else for example (4,5,7,8).");
            string answerInput = Console.ReadLine();
            bool answer = byte.TryParse(answerInput, out byte isZero) && isZero == 0 ? true : false;
            if (answer)
            {
                HightInput();
            }
            else
            {
                ExamplesData();
            }
        }

        public static void ExamplesData()
        {
            string currnetClock , newLine = Environment.NewLine;
            currnetClock = B18_Ex01_02.Ex01_02_Class.SandClock(4);
            Console.WriteLine("Hight 4{0}{1}", newLine, currnetClock);
            currnetClock = B18_Ex01_02.Ex01_02_Class.SandClock(5);
            Console.WriteLine("Hight 5{0}{1}", newLine,currnetClock);
            currnetClock = B18_Ex01_02.Ex01_02_Class.SandClock(7);
            Console.WriteLine("Hight 7{0}{1}", newLine, currnetClock);
            currnetClock = B18_Ex01_02.Ex01_02_Class.SandClock(8);
            Console.WriteLine("Hight 8{0}{1}", newLine, currnetClock);

        }

        public static void HightInput()
        {
            ushort clockHight;
            Console.WriteLine("Insert number that is hight of the clock, between 0 to {0}", ushort.MaxValue);
            string inputHight = Console.ReadLine();
            while (!ushort.TryParse(inputHight, out clockHight))
            {
                Console.WriteLine("Wrong input. insert again.");
                inputHight = Console.ReadLine();
            }

            string sandTimeToPrint = B18_Ex01_02.Ex01_02_Class.SandClock(clockHight);
            Console.WriteLine(sandTimeToPrint);

        }


    }
}
