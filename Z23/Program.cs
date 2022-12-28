/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear(); 

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Таблица кубов числа {number}");
int num = number; 

void PrintQuart(int num)
{
    for (int i = 1; i <= num; i++)
    Console.WriteLine($"{i} \t {i*i*i}");
}
if (num < 1)
Console.WriteLine("Введите число > 1");

PrintQuart(num);