using System;

namespace Task_3_Array_manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             1. Declare an array to store 10 numbers
             2. Prompt the user to enter 10 numbers and store them in the array
             3. Modify the values of the array by dividing each value by its index + 1
             4. Print the new values
             5. End     */

            // Declaring an array to store 10 numbers
            int[] numbers = new int[10]; 


            // Prompt the user to enter 10 numbers and store them in the array
            for (int i = 0; i < numbers.Length; i++)

            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Modify the values of the array
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] / (i + 1);
            }

            // Print the new values
            for (int i = 0; i < numbers.Length; i++)

            {
                Console.WriteLine("New value at index {0}: {1}", i, numbers[i]);
            }
            Console.ReadLine(); 

        }
    }
}
