// Задача. Ввод n, вывод находящихся в нём четных чисел

// Через "WHILE"

/* Console.Write("Число: ");
int number = int.Parse(Console.ReadLine());
int j = 2;
if (i > number) Console.WriteLine("Четных чисел нет");
while (i <= number)
{
    if ((i % 2 == 0 && i == number) || (i % 2 == 0 && i + 1 == number))
    {
        Console.Write(i);
    }
    else if (i % 2 == 0)
    {
        Console.Write(i + ",");
    }
    i++;
} */


// Через "FOR"+рандом
/* Console.Write("Число: ");
int number = new Random().Next(2000);
for (int j = 2; j <= number; j++)
{

    if ((j % 2 == 0 && j == number) || (j % 2 == 0 && j + 1 == number))
    {
        Console.Write(j);
    }
    else if (j % 2 == 0)
    {
            Console.Write(j + ", ");
    }
}
Console.WriteLine();
Console.Write(number); */


//Задача 2.
// Написать программу, которая выводит слуяайное число из отрезка [10, 99]
// и покаваывет наибольшую цифру в нём.
// Напрмиер:
// 78->8 
// 12->2
// 85->8

// Решение:

/* int r = new Random().Next(10, 100);
Console.WriteLine(r);
int fD = r / 10;
int sD = r % 10;
if(fD>sD)
{
    Console.WriteLine(fD);
}
else if(fD==sD)
{
    Console.WriteLine("цифры равны");
}
else
{
    Console.WriteLine(sD);
} */