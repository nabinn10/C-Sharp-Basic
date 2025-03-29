using System;
 class Hello
 {
        public static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the elements is array");
            for(int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // using bubble sort
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5 - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("The sorted array is");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
 }