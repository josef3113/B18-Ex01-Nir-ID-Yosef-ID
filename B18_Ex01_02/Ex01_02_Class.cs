using System;
using System.Text;

namespace B18_Ex01_02
{
    public class Ex01_02_Class
    {
        public static void Ex01_02_Start() // Ex01_02_Start
        {
            Console.WriteLine("Hey, Ex01_02");
            string sandTime = SandClock(); // default input is 5.
            Console.WriteLine(sandTime);
            
        }

        public static string SandClock(ushort i_ClockHight = 5)
        {// i add 1 for even input.
            StringBuilder srtingToPrint = new StringBuilder(i_ClockHight * i_ClockHight);
            ushort space = (ushort)(i_ClockHight / 2) , currentSize = 3;
            srtingToPrint.Append(MakeLine(1, space));
            while (space > 0)
            {
                space--;
                string lineToAdd = MakeLine(currentSize, space);
                srtingToPrint.Insert(0, lineToAdd);
                srtingToPrint.Append(lineToAdd);
                currentSize += 2;
            }

            return srtingToPrint.ToString();
        }

        static string MakeLine(ushort i_StarLength, ushort i_SpaceCount)
        {
            StringBuilder lineCurrent = new StringBuilder(i_StarLength + i_SpaceCount);
            lineCurrent.Append(' ', i_SpaceCount);
            lineCurrent.Append('*', i_StarLength);
            return string.Format("{0}{1}", lineCurrent, Environment.NewLine);
        }
    }
}