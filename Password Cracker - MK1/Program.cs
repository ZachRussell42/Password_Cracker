using System;

namespace Password_Cracker___MK1
{
    class Program
    {
        static void Main(string[] args)
        {
            // properties
            string password;
            int[] tally = {0,0,0,0,0};
            bool isCracked = false;
            bool isStart = false;

            Console.WriteLine("Input a 5 letter password:");
            password = Console.ReadLine();

            while (isCracked == false)
            {
                string guess = PasswordCracker(password.Length, ref tally, ref isCracked, ref isStart);
                if (guess == password)
                {
                    isCracked = true;
                    Console.WriteLine($"SUCCESSFUL PASSWORD CRACK - PASSWORD : {guess}");
                    
                }
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        static string PasswordCracker(int passwordLength, ref int[] tally, ref bool isCracked, ref bool isStart)
        {
            // char position  {  0    1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19   20   21   22   23   24   25   26   27   28   29   30   31   32   33   34   35   36   37   38   39   40   41   42   43   44   45   46   47   48   49   50   51   52   53   54   55   56   57   58   59   60   61}
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string guess = "";

            char[] guessArray = new char[passwordLength];

            if (isStart == true)
            {

                if(tally[4] < 61)
                {
                    tally[4]++;
                }
                if (tally[4] == 61 && tally[3] < 61)
                {
                    tally[4] = 0;
                    tally[3]++;
                }
                if (tally[3] == 61 && tally[2] < 61)
                {
                    tally[4] = 0;
                    tally[3] = 0;
                    tally[2]++;
                }
                if (tally[2] == 61 && tally[1] < 61)
                {
                    tally[4] = 0;
                    tally[3] = 0;
                    tally[2] = 0;
                    tally[1]++;
                }
                if (tally[1] == 61)
                {
                    tally[4] = 0;
                    tally[3] = 0;
                    tally[2] = 0;
                    tally[1] = 0;
                    tally[0]++;
                }
            }



            guessArray[0] = alphabet[(tally[0])];
            guessArray[1] = alphabet[(tally[1])];
            guessArray[2] = alphabet[(tally[2])];
            guessArray[3] = alphabet[(tally[3])];
            guessArray[4] = alphabet[(tally[4])];

            guess = new String(guessArray);
            isStart = true;
            

            return guess;         
        }
    }
}
