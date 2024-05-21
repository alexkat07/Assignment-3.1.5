using System.Security.Cryptography;

namespace Assignment_3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 0, 2, 1, 1, 9, 1, 1 };
            int Left = 0;
            int Right = 1;
            while (Right < myArray.Length) 
            {
                if (myArray[Left] == 1 && myArray[Right] == 1)
                {
                    myArray[Left] = 0;
                    myArray[Right] = 0;
                }
                Left += 1;
                Right += 1;
            }
            foreach (int num in myArray) 
            {
                Console.Write(num + ",");
            }
         }
    }
}
