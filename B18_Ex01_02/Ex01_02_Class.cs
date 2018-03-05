using System;

using System.Text;


namespace B18_Ex01_02
{
    public class Ex01_02_Class
    {
        public static void Ex01_02_Start()
        {
            Console.WriteLine("Hey Ex01_02 !");
            PrintSendTimeStar(5);

            int inputSizeNumber;
            bool quit = false;
           // string inputSize = Console.ReadLine();
            while (!quit) {
                Console.WriteLine("Enter number Please");
                string inputSize = Console.ReadLine();
                if (int.TryParse(inputSize, out inputSizeNumber))
                {
                    quit = true;
                }
                else {
                    Console.WriteLine("Worng Input!! Try again.");
                }
            }

        }

        public static void PrintSendTimeStar(int i_SizeOfSendTime) {
            Console.WriteLine("Const Send Time");
            string sendTime = String.Format(
@"
*****
 ***
  *
 ***
*****

End const time send");
            int size = 5;

            StringBuilder buildSendTimeStar = new StringBuilder(size*size);
            int sizeToTrack = size;
            int midle = size / 2;
            while (sizeToTrack > midle) {
                for (int i = 0; i < sizeToTrack; i++)
                {
                    char chary;
                    chary = sizeToTrack+i < size  ? ' ' : '*' ;
                    buildSendTimeStar.Append(chary);

                }
                buildSendTimeStar.AppendFormat("A{0}",Environment.NewLine);                                
                sizeToTrack--;

            }

            Console.WriteLine(buildSendTimeStar.ToString());
            Console.WriteLine("End!");
            sizeToTrack = 0;
            while (sizeToTrack < midle)
            {
                for (int i = 0; i < midle+2+sizeToTrack; i++)
                {
                    char chary;
                    chary = sizeToTrack + 1 + i < midle ? ' ' : '*';
                    buildSendTimeStar.Append(chary);

                }
                buildSendTimeStar.AppendFormat("Z{0}", Environment.NewLine);
                sizeToTrack++;
            }
            
            Console.WriteLine(sendTime);
            //buildSendTimeStar;
            Console.WriteLine(buildSendTimeStar.ToString());
            Console.WriteLine("End!");

            // first loop *****
            //             ***

            // secound loop ***
            //             *****


        }
    }
}
