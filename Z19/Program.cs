/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
Console.Clear();

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Вы ввели некорректное число");
}
else 
{
    int Digit1 = num / 10000;
    int Digit2 = num / 1000 % 10;
    int Digit3 = num / 100 % 10;
    int Digit4 = num / 10 % 10;
    int Digit5 = num % 10;

    
    if (Digit1 == Digit5 && Digit2 == Digit4)
    Console.WriteLine("Число является полиндромом");
    else Console.WriteLine("Число не является полиндромом");
};
