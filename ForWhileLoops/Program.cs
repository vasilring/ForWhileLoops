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

//Test Push

//asd

//test 2
