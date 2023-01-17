// For && While Loops Telerik

// Task 1

//Not Divisible Number

//Description
//Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7

//Input
//Will always consists of one valid integer number - the number N.

//Output
//Should always consists of the numbers from 1 to N, which are not divisible by 3 or 7, separated by a whitespace.

//Constraints
//1 < N < 1500

//Sample tests
//Input    Output
//10    1 2 4 5 8 10
//3    1 2

//Task 2

//Write a method that reverses the digits of a given decimal number. - hint: use string instead of decimal to iterate
// Input 70  Output 07

//------------------------------------------------------------------------------------------------------------------------------------

// Not Divisible Number

//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)

//{

//    if (i % 3 == 0 || i % 7 == 0)

//        continue;

//        Console.Write($"{i} ");

//}

// Reversed Number

//string number =Console.ReadLine();

//for (int i = number.Length -1; i >= 0; i--)

//{

//    Console.Write(number[i]);

//}


// Prime numbers
// Print all the prime numbers between 1 and N
// N is an input
// 1 is a prime number && 1<= N <=1024

//using System.Globalization;

//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number && number <= 1024; i++)

//{
//    bool prime = true;

//    for (int z = 2; z <= Math.Sqrt(i); z++)

//    {

//        if (i % z == 0) 

//        { 

//        prime = false;

//        break;

//        }

//    }

//    if (prime)

//    {

//        Console.Write(i + " ");

//    }

//}


// Balanced Number

// Balanced Number is a 3 digit number whose second digit is equal to the sum of the first and the third digit
// Input 132     Output 132
//       123


//int inputs = 1000;

//for (int i = 1;i < inputs; i++)

//{

//    int number = int.Parse(Console.ReadLine());

//    int firstNumber = number / 100;

//    int secondNumber = number % 100 / 10;

//    int thirdNumber = number % 100 % 10;

//    int sum = firstNumber + thirdNumber;

//        if (number.ToString().Length == 3)

//        {

//             if (sum == secondNumber)

//             {
//                  Console.WriteLine(number);

//                     continue;

//             }

//             else if (sum > secondNumber) 

//             {

//                    break;

//             }

//        }

//         else 

//         { 

//                 Console.WriteLine("Invalid input, please try again and enter 3 digit number"); 

//         }

//}  

//------------------------------------------------------------------------------------------------------------------------------------

//Number Wave
//Description
//Write a program that prints a wave till a certain number and backward.

//Input

//On the first line, you will receive the number N.

//Output

//Print a "wave" i.e. the numbers from 1 to N and then the numbers from N - 1 to 1 on a single line separated by space.
//Constraints

//1 <= N <= 1000

//Sample tests

//Input

//3

//Output

//1 2 3 2 1

//int number = int.Parse(Console.ReadLine());

//for (int i = 1;i <= number; i++)

//{

//    Console.Write(i + " ");

//}

//for (int z = number - 1; z >= 1; z--)

//{

//    Console.Write(z + " ");

//}

// Write a program that calculates N! / K! for given N and K
// * Use only one loop
// 1 < K < N < 100


//ulong n = ulong.Parse(Console.ReadLine());
//ulong k = ulong.Parse(Console.ReadLine());

//ulong factorialN = 1;
//ulong factorialK = 1;

//do

//{

//    if (n > 0)
//    {
//        factorialN *= n;

//        n -= 1;
//    }


//    if (k > 0)
//    {
//        factorialK *= k;

//        k -= 1;
//    }



//}

//while ((n > 0) || (k > 0));

//ulong sum = factorialN / factorialK;

//Console.WriteLine(sum);


// New
//Sqrt(x)
//Easy

//Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

//You must not use any built-in exponent function or operator.

//For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.


//Example 1:

//Input: x = 4
//Output: 2
//Explanation: The square root of 4 is 2, so we return 2.
//Example 2:

//Input: x = 8
//Output: 2
//Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.

//double numberSqrt = double.Parse(Console.ReadLine());

//double sqrt = Math.Sqrt(numberSqrt);

//double finalNumber = Math.Floor(sqrt);


//Console.WriteLine(finalNumber);

//Longest String
//You are very hungry, but there is a problem - there is just too much options and you can only eat one thing. Being a clever programmer, you decide to form objective critera and eat the food with the longest name. Also, why count manually in 30 seconds, when you can spend 15 minutes writing a script to do the counting?

//Input
//The input consists of at least 2 lines
//The last line is always END
//Each different food is on a new line
//Output
//Print the food with the longest name. If two or more foods have equal length, print the last one.
//Constraints
//1 <= lines of input <= 50 The last line will always be END

//Sample Tests
//Input
//pizza
//macaroni
//kiufte
//banica
//END
//Output
//macaroni

//string food = " ";
//string maxLength = " ";

//while (true) 
//{ 
//    food = Console.ReadLine();

//        if (food == "END")

//            {

//             break;

//            }

//        if(food.Length >= maxLength.Length)
//    {
//        maxLength = food;
//    }


//}

//Console.WriteLine(maxLength);

//Smaller, greater or equal?
//Description
//Write a program that reads from the console a sequence of n integer numbers and prints these numbers with the correct sign between them.

//Input
//On the first line, you will receive the number N
//On each of the next N lines, you will receive a number
//Output
//Print on a single line with "<", ">" or "=" between the numbers.
//Constraints
//1 <= N <= 1000
//Sample tests
//Input
//3
//2
//5
//1

//string result = "";
//int temp = 0;

//int count = int.Parse(Console.ReadLine());
//for (int i = 0; i < count - 1; i++)
//{
//    if (i == 0)
//    {
//        int num = int.Parse(Console.ReadLine());
//        temp = num;
//        result += num;
//    }
//    int current = int.Parse(Console.ReadLine());

//    if (current > temp)
//    {
//        result += "<" + current;
//        temp = current;
//    }
//    else if (current < temp)
//    {
//        result += ">" + current;
//        temp = current;
//    }
//    else if (current == temp)
//    {
//        result += "=" + current;
//    }
//}
//Console.WriteLine(result);

// Мисли задачата утре - ВАЖНО!!!!
// Мисли задачата утре - ВАЖНО!!!!

// New Task

//Pyramid of number
//1
//12
//123
//12
//1

//using System.Globalization;

//int number = int.Parse(Console.ReadLine());

//// Increment value
//for (int i = 1; i <= number; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}
//// Decrement value
//for (int i = number-1; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}    







   





