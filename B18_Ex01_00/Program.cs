using System;

namespace B18_Ex01_00
{
    public class Program
    {
        public static void Main()
        {
            Menu();
        }

        static public void Menu()
        {
            eChosenTask chosenTask;
            Console.WriteLine("Welcome to Menu of B18_Ex01");
            bool quit = false;
            string menuOpstions = string.Format(
@"
Exit by insert 0
Ex01_01 insert 1
Ex01_02 insert 2
Ex01_03 insert 3
Ex01_04 insert 4
Ex01_05 insert 5");
            while (!quit)
            {
                Console.WriteLine(menuOpstions);
                string optionsInput = Console.ReadLine();
                chosenTask = byte.TryParse(optionsInput, out byte options) && options < 6 ? (eChosenTask)options : eChosenTask.WrongIput;
                Console.Clear();
                switch (chosenTask)
                {
                    case eChosenTask.Exit:
                        quit = true;
                        break;
                    case eChosenTask.Ex01_01:
                        B18_Ex01_01.Ex01_01_Class.Ex01_01_Start();
                        break;
                    case eChosenTask.Ex01_02:
                        B18_Ex01_02.Ex01_02_Class.Ex01_02_Start();
                        break;
                    case eChosenTask.Ex01_03:
                        B18_Ex01_03.Ex01_03_Class.Ex01_03_Start();
                        break;
                    case eChosenTask.Ex01_04:
                        B18_Ex01_04.Ex01_04_Class.Ex01_04_Start();
                        break;
                    case eChosenTask.Ex01_05:
                        B18_Ex01_05.Ex01_05_Class.Ex01_05_Start();
                        break;
                    default:
                        Console.WriteLine("Wrong input! insert again.");
                        break;
                }
            }
        }

        public enum eChosenTask : byte
        {
            Exit,
            Ex01_01,
            Ex01_02,
            Ex01_03,
            Ex01_04,
            Ex01_05,
            WrongIput = 200
        }

    }
}