using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resulting all the self dividing numbers between two numbers ");
            Console.WriteLine("Input the first value");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second value");
            int y = int.Parse(Console.ReadLine());
            printSelfDividingNumbers(x,y);

            Console.WriteLine(); 

            int n2 = 20;
            printSeries(n2);

            Console.WriteLine();

            int n3 = 3;
            printTriangle(n3);

            Console.WriteLine();

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);

            Console.WriteLine();

            /*int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);*/
            
            solvePuzzle();
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
                // Initialized a list to store the result of the series 
                var result = new List<int>();
                // a nested for loop to generate the series based on n 
                // running for loop from i=1 to n
                for (int i = 1; i <= n; i++)
                {
                    // for loop for every i while iterating j from 0 to j<1 (to print the number i, i times)
                    for (int j = 0; j < i; j++)
                    {
                        //adding the result into the list 
                        result.Add(i);
                    }
                }
                // for loop to access elements in the list from i=0 to i<n
                for (int i = 0; i < n; i++)
                {
                    // printing the output
                    Console.Write("{0},", result[i]);
                }
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
                // running a for loop from 0 to n as we need to display n number of rows
                for (int i = 0; i < n; i++)
                {
                    // now runnning a for loop to access each element in the ith row. Logic is that the length of the row is 2*n-1
                    for (int j = 0; j <= (2 * n) - 1; j++)
                    {
                        /*Now this condition is for the position of spaces. As we need to get a reverse pyramid, 
                        I have given spaces at the starting of the row and at the ending of the row depending on the row we are in 
                        The logic is that 1st row has zero spaces, second row has 2 spaces(one at the starting other at the ending) and so on*/
                        if (j <= i || j > (2 * n) - 1 - i)
                            Console.Write(" ");
                        //if the above condotion is not satisfied, we are printing a star here.
                        else Console.Write("*");
                    }
                    // used console.writeline to take the output after each row into next line
                    Console.WriteLine();
                }
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
                // Intializing the count variable to zero
                int count = 0;
                // running a for loop to access all the elements of the arraj J
                for (int i = 0; i < J.Length; i++)
                {
                    // A nested loop to be able to access all the elements of array S for every i i.e(all the elements of arraj ).
                    
                    for (int j = 0; j < S.Length; j++)
                    {
                        //if condition  to increase the count if an element of J is equal to element of S 
                        if (J[i] == S[j])
                        {
                            count = count + 1;
                        }

                    }
                    

                }
                // returning the count of stones which are also jewels.
                return count;
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
                /* creating  hashset to store the comman elements in the arrays and to not take any duplicate values */
                HashSet<int> ElementsinComman = new HashSet<int>();
                /* sorting the two arrays in ascending order*/
                Array.Sort(a);
                Array.Sort(b);
                /* Initialized a nested for loop to find the comman elements in both the arrays and if comman then adding them to the 
                 ElementsinComman hash set we have initialized before*/
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                        {
                            ElementsinComman.Add(a[i]);
                        }
                    }
                }

                /* creating a dictionary to store the comman sub arrays */
                Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
                /* Looping through hash set 'hs' to find contigous array */
                foreach (int y in ElementsinComman)
                {
                    
                }
         
            
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