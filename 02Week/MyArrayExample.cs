using System;

namespace ConsoleApplication
{
    public class MyArrayExample
    {
        public void Run()
        {
            //How to use an array
            string[] arr1 = new string[] { "morning", "evening", "afternoon" };

            //Get the length of the array
            Console.WriteLine(arr1.Length);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            int[] arr2 = new int[] { 100, 200, 300 };

            for (int j = 0; j < arr2.Length; j++)
            {
                Console.WriteLine(arr2[j]);
            }

            // Console.WriteLine( arr2[1] );
        }
    }
}