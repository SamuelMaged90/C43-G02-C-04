using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter Number");
            //bool state = int.TryParse(Console.ReadLine(), out int num);
            //if (state)
            //{
            //    int num02 = 1;
            //   while (num02 <=num)
            //   {
            //        Console.WriteLine(num02);
            //        num02++;
            //   }
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter Number");
            //bool state = int.TryParse(Console.ReadLine(), out int num);
            //if (state)
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write(num * i);
            //    }
            //}

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter Number");
            //bool state = int.TryParse(Console.ReadLine(), out int num);
            //if (state)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        if(i %2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}


            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine("Enter Power");
            //int.TryParse(Console.ReadLine(), out int power);
            //int result = 1;
            //for (int i = 0; i < power; i++)
            //{
            //    result = result * num;
            //}
            //Console.WriteLine(result);
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Enter Marks of 5 Subjects");
            //int[] Marks = new int[5];
            //int sum = 0;
            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out Marks[i]);
            //    sum += Marks[i];
            //}
            //Console.WriteLine($"The Sum is {sum}");
            //Console.WriteLine($"The Average is {sum / Marks.Length}");
            //Console.WriteLine($"The Percentage is {(sum*1.0 / (Marks.Length *100))* 100}");


            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Enter String");
            //string? name = Console.ReadLine();

            //char[] arr = name.ToCharArray();

            //Array.Reverse(arr);

            //name = new string(arr);

            //Console.WriteLine(name);


            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Enter an integer: ");

            //int.TryParse(Console.ReadLine(),out int num);

            //string numberString = num.ToString();

            //char[] charArray = numberString.ToCharArray();

            //Array.Reverse(charArray);

            //string reversedString = new string(charArray);

            //int reversedNumber = int.Parse(reversedString);

            //Console.WriteLine($"Reversed integer: {reversedNumber}");
            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("Enter Number Start");
            //int.TryParse(Console.ReadLine(), out int start);
            //Console.WriteLine("Enter Number End");
            //int.TryParse(Console.ReadLine(), out int End);

            //for (int i = start; i <= End; i++)
            //{
            //    if (i >1)
            //    {
            //        bool prime = true;

            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                prime = false;
            //                break;
            //            }
            //        }
            //        if (prime)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}


            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter a decimal number: ");
            //int.TryParse(Console.ReadLine(),out int DecimalNumber);

            //string binaryRepresentation = "";

            //while (DecimalNumber > 0)
            //{
            //    // Get the remainder (either 0 or 1) when dividing by 2
            //    int remainder = DecimalNumber % 2;

            //    // Prepend the remainder to the binary representation string
            //    binaryRepresentation += remainder.ToString() ;

            //    // Update the decimal number by dividing it by 2
            //    DecimalNumber /= 2;
            //}

            //char[] reversed = binaryRepresentation.ToCharArray();

            //Array.Reverse(reversed);

            //binaryRepresentation = new string(reversed);

            //Console.Write(binaryRepresentation);
            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.Write("Enter x1: ");
            //double.TryParse(Console.ReadLine(),out double x1);

            //Console.Write("Enter y1: ");
            //double.TryParse(Console.ReadLine(), out double y1);

            //Console.Write("Enter x2: ");
            //double.TryParse(Console.ReadLine(), out double x2);

            //Console.Write("Enter y2: ");
            //double.TryParse(Console.ReadLine(), out double y2);

            //Console.Write("Enter x3: ");
            //double.TryParse(Console.ReadLine(),out double x3);

            //Console.Write("Enter y3: ");
            //double.TryParse(Console.ReadLine(), out double y3);

            //// Check if the points are collinear
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the matrix (n): ");
            //int.TryParse(Console.ReadLine(),out int n);

            // Generate and print the identity matrix
            //for (int i = 0; i < n; i++)  // Outer loop for rows
            //{
            //    for (int j = 0; j < n; j++)  // Inner loop for columns
            //    {
            //        // Print 1 if it is a diagonal element, otherwise print 0
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr = new int[] { 1, 2, 3 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr01 = new int[] {1,3,5};
            //int[] arr02 = new int[] {2,4,6};

            //int[] arr03 = new int[arr01.Length + arr02.Length];

            //Array.Copy(arr01,arr03, arr01.Length);

            /*Array.Copy(from Array,index start,To Array,Copy From index, length of from array); */
            //Array.Copy(arr02,0,arr03,3, arr02.Length);

            //Array.Sort(arr03);

            //for (int i = 0; i < arr03.Length; i++) 
            //{
            //    Console.WriteLine(arr03[i]);
            //}


            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = new int[] {1,2,2,3,5,5,6,8,7,9,9,10,12,2,8};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 1; 
            //    for (int j = i + 1; j < arr.Length; j++)  // Compare with all elements after it
            //    {
            //        if (arr[i] == arr[j])  
            //        {
            //            count++;  
            //            arr[j] = -1;  // Set the matched element to -1 to avoid counting it again
            //        }
            //    }
            //    if (arr[i] != -1)  // Only print for elements that have not been counted yet
            //    {
            //        Console.WriteLine($"Element {arr[i]} appears {count} time(s).");
            //    }
            //}
            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = new int[] { 1, 2, 3 ,4 ,5 ,6 ,7 ,8 ,9 ,10 };

            //int max = arr[0];
            //int min = arr[0];

            //// Traverse the array to find max and min
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i]; // Update max
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i]; // Update min
            //    }
            //}

            //Console.WriteLine(min);
            //Console.WriteLine(max);
            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr= new int[] {5,6,7,8,9,4,2,3,1,10};

            //Array.Sort(arr);
            //Array.Reverse(arr);

            //Console.WriteLine(arr[1]);
            #endregion

            #region 17-. Consider an Array of Integer values with size N, having values as in this Example

            //int[] arr = new int[10];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = -1;

            //// Traverse the array to find the longest distance between equal cells
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j]) 
            //        {
            //            int distance = j - i - 1;  // Calculate the number of cells between them
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;  
            //            }
            //        }
            //    }
            //}

            //if (maxDistance == -1)
            //{
            //    Console.WriteLine("No equal cells found with a distance.");
            //}
            //else
            //{
            //    Console.WriteLine($"The longest distance between two equal cells is: {maxDistance} cells.");
            //}

            #endregion

            #region 18- Given a list of space separated words, reverse the order of the words.

            //Console.Write("Enter a list of space-separated words: ");
            //string input = Console.ReadLine();

            //// Split the input string into an array of words
            //string[] words = input.Split(' ');

            //// Reverse the array of words
            //Array.Reverse(words);

            //// Join the reversed words into a single string and print the result
            //string reversedWords = string.Join(" ", words);
            //Console.WriteLine("Reversed order of words: " + reversedWords);



            #endregion

            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int columns = int.Parse(Console.ReadLine());

            //int[,] array1 = new int[rows, columns];
            //int[,] array2 = new int[rows, columns];

            //Console.WriteLine("Enter the elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(array2[i, j] + " "); 
            //    }
            //    Console.WriteLine(); 
            //}
            #endregion

            #region 20- Write a Program to Print One Dimensional Array in Reverse Order
            
            //int[] arr = new int[5];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    int.TryParse(Console.ReadLine(),out arr[i]);
            //}

            //Console.WriteLine("Array in reverse order:");

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion
        }
    }
}
