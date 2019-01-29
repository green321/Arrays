/*
 Author: Yue Xu
 Date:   1/28/2019
 Comment:1. Choose either type of array (Manually populated for Auto populated) seen in the example
         2. The program doesn't ask the user anything, it will just run and execute code. No user input.
         3. Have the program execute an array that is of size 25 elements.
         4. Then, have the code simply display in the Console the following 25 times (Here is a sample of the output):
         Element value = 1
         Element value = 2
         Element value = 3
         .......... and so on .....
         Element value = 25
         Once you complete this program, upload them to GitHub.
         Then, paste your 2 GitHub Link to GitHub here.
 */

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello 😀");

            try
            {

                Console.WriteLine("");
                Console.WriteLine("First, let's manually populat a array");
                Console.WriteLine("Then, let's iterate through the elements in the array with a Foreach Loop");

                //Muanully populate an array that is of size 25 element
                int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };


                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("There are 25 elements should be populated in the array.");
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine("");

                //iterate through the array using a Foreach Loop
                foreach(int i in Numbers)
                {
                    Console.WriteLine(" Element value = " + i);
                }
                Console.WriteLine("");
                Console.WriteLine("________________________________________________________________________");
                Console.WriteLine("Press any key to exit the program...");

                //pause the program and await the user to press a key to end the program
                Console.ReadKey(true);


            }//End of try

            catch
            {
                Console.WriteLine("Please exit the program and try again later...");
                Console.ReadKey(true);

            }//End of catch

        }
    }
}
