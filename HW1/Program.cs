/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее. */

/* Console.Write("Input num1 ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Input num2 ");
int num2 = int.Parse(Console.ReadLine() ?? "");


if(num1>num2)
{
    Console.WriteLine("num1 - More");
    Console.WriteLine("num2 - Less");
}
else
{
    Console.WriteLine("num1 - Less");
    Console.WriteLine("num2 - More");
} */

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. */


/* Console.Write("Input num1 ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Input num2 ");
int num2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Input num3 ");
int num3 = int.Parse(Console.ReadLine() ?? "");

int Max;

Max = num1;
if (num2>Max) Max = num2;
if (num3>Max) Max = num3;

Console.WriteLine(Max); */

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/

/* Console.Write("Input number ");
int num = int.Parse(Console.ReadLine() ?? "");

if(num % 2 == 0)
Console.WriteLine("even");


else 
Console.WriteLine("not even"); */

/* Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N. */

/* Console.Write("Input number ");
int num = int.Parse(Console.ReadLine() ?? "");

int current = 1;
if (num <= 1)
{
    Console.WriteLine("not even");
}
else
   while (current <= num)
   {
     if (current % 2 == 0)
     {
Console.WriteLine(current + " ");
current = current + 2;
     }
     else
     {
    current = current + 1;
     }
} */

















 
 