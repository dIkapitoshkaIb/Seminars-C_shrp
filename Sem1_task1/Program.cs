/* написать программу, которая на вход принимает число и умножает его на себя(возводит в квадрат)

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(number * number); */






/* Написать программу для нахождения квадрата.

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

if (a == (b * b))
{
    Console.WriteLine("Является квадратом");
}
else
{
    Console.WriteLine("Не является квадратом");
} */





/* Написать программу, определяющую выходной день в неделе.

 Console.WriteLine("Введите день недели: ");
string num = Console.ReadLine();
switch(num)
{
    case "1":
    Console.WriteLine("Пн");
    break;
    case "2":
    Console.WriteLine("Вт");
    break;
    case "3":
    Console.WriteLine("Ср");
    break;
    case "4":
    Console.WriteLine("Чт");
    break;
    case "5":
    Console.WriteLine("Пт");
    break;
    case "6":
    Console.WriteLine("Сб");
    break;
    case "7":
    Console.WriteLine("Вс");
    break;
    default:
    Console.WriteLine("Нет такого дня недели");
    break;
} */






/* Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"


Console.WriteLine("Введите значение: ");
int number = int.Parse(Console.ReadLine()!);

for(int firstNumber = -number; firstNumber <= number; firstNumber++)
{
    Console.Write(firstNumber + " ");
}  */





/* Написать программу, которая на вход принимает трёхзначное число и выводит его последнюю цифру

Console.WriteLine("Введите значение: ");
int num = int.Parse(Console.ReadLine()!);
if (num > 99 && num < 1000)
{
    int last = (num % 10);
    Console.WriteLine("Последнее число: " + last);
}    
else 
    Console.WriteLine("Это не трёхзначное число");
  */





/* using System;

class Program
{
static void Main(string[] args)
{
for (int i = 1; i <= 100; i++)
{
if (i % 15 == 0)
{
Console.WriteLine("FizzBuzz");
}
else if (i % 3 == 0)
{
Console.WriteLine("Fizz");
}
else if (i % 5 == 0)
{
Console.WriteLine("Buzz");
}
else
{
Console.WriteLine(i);
}
}
}
} */


/* 
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 10;
if(number > 99 && number < 1000)
{
    Console.WriteLine("Последняя цифра числа: " + lastDigit);
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}
}
} */





/* Console.WriteLine("Введите трехзначное число:");
string number = Console.ReadLine()!;
int len = number.Length;

if(len == 3)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}
Console.WriteLine("Последнее число значения " + number + ": " + number[2]); */