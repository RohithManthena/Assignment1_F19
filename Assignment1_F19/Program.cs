using System;
namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
/*            Console.WriteLine("Resulting all the self dividing numbers between two numbers ");
            Console.WriteLine("Input the first value");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second value");
            int y = int.Parse(Console.ReadLine());
            printSelfDividingNumbers(x,y);*/
            int n2 = 20;
            printSeries(n2);
            /*int n3 = 5;
            printTriangle(n3);
            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S); Console.WriteLine(r4);
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);
            solvePuzzle();*/
        }
        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            { 
                // Running a for loop to input all the numbers between x and y into the logic below
                for (int i = x; i <= y; i++)
                {
                    // used a boolean fun to set a variable as true which we will be using to check if a number is self dividing or not
                   var selfdividing=true;
                   for (int j = i; j > 0; j /= 10)
                   {
                        //
                            int a = j % 10;
                            if (a == 0 || i % a != 0)
                            {
                                selfdividing = false;
                                break;
                            }
                   }
                   if(selfdividing==true)
                    {
                        Console.Write("{0},",i);
                    }
                }
                
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }
        public static void printSeries(int n)
        {
            try
            {
                int print_count = 0;
                int start_count = 1;
                do
                {
                    for (int i = 0; i < start_count; i++)
                    {
                        Console.Write("{0},",start_count);
                        print_count += 1;
                        if (print_count == n)
                        {
                            break;
                        }
                    }
                    start_count += 1;
                }
                while (print_count < n);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }
        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here            
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
            return 0;
        }
        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
            return null;
            // return the actual array        
        }
                public static void solvePuzzle()
        {
            try
            {
                // Write your code here            
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
}