/*
    Author: Valentina Delgado-Rodriguez
    Date: 09/24/2020
    Comments: Create a C# console application that executes a manually populated array 
              that is the size of 25 elements.
*/

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // displays a message letting the user know that it is populating an array
            // that is the size of 25 elements
            Console.WriteLine("Executing a manually populated array that is the size of 25 elements:");

            // create an array that contains the numbers from 1-25
            int[] countdown = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17,
            18, 19, 20, 21, 22, 23, 24,25};

            // foreach loop will iterate inside the countdown array until the last item 
            foreach(int i in countdown)
            {
                // display a message everytime the foreach loop iterates with the element value and the number
                Console.Write("Element value: " + i + "\n");
            }

            // will let the user exit the program 
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);

        }// end of main
    }// end of class
}// end of namespace
