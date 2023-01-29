// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter number1: ");
string strNumber1 = Console.ReadLine();

int number1 = Convert.ToInt32(strNumber1);

Console.Write("Enter number2: ");
string strNumber2 = Console.ReadLine();

int number2 = Convert.ToInt32(strNumber2);

Console.WriteLine("    ");
Console.WriteLine("************"); 

if(number2>number1)
{
    Console.Write("Max number ");
    Console.WriteLine(number2);
    Console.Write("Min number ");
    Console.WriteLine(number1);
}
else
{

 

    Console.Write("Max number ");
    Console.WriteLine(number1);
    Console.Write("Min number ");
    Console.WriteLine(number2);
}
    Console.WriteLine("************");
    Console.WriteLine("    ");


// Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter numberA: ");
string strNumberA = Console.ReadLine();

int numberA = Convert.ToInt32(strNumberA);

Console.Write("Enter numberB: ");
string strNumberB = Console.ReadLine();

int numberB = Convert.ToInt32(strNumberB);

Console.Write("Enter numberC: ");
string strNumberC = Console.ReadLine();

int numberC = Convert.ToInt32(strNumberC);

int  max = numberA;

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.WriteLine("    ");
Console.WriteLine("************");  
Console.Write("Maximal number = ");
Console.WriteLine(max);
Console.WriteLine("************");
Console.WriteLine("    ");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("OK, once again, enter new number: ");
string strNumber = Console.ReadLine();

int number = Convert.ToInt32(strNumber);

Console.WriteLine("    ");
Console.WriteLine("************");  

if(number%2==0)
{
    
    Console.WriteLine("Great! Entred number is even");
    Console.WriteLine("************");
    Console.WriteLine("    ");
}
else
Console.WriteLine ("Oh, no! This is odd number");
Console.WriteLine("************");
Console.WriteLine("    ");

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine ("Now I show you all even number till yours");
Console.WriteLine("    ");

int num = number;

if(number>0)
{
        num = 2;
        while(num < number)
            {
                if(num%2==0)
                {
                    Console.Write(num);
                    Console.Write(", ");  
                    num++;
                }
            else
            num++;
            }
    Console.WriteLine("    ");
    Console.WriteLine("    "); 
}
else
Console.WriteLine("Sorry, but your entered negative number =(");
Console.WriteLine("    ");
Console.WriteLine("    ");
Console.WriteLine("No magic for today...");
