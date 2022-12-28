/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

int getUserValue(string massage)
{
    Console.WriteLine(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int xa1 = getUserValue("Введите кординату X числа A");
int ya1 = getUserValue("Введите кординату Y числа A");
int za1 = getUserValue("Введите кординату Z числа A");

int xb2 = getUserValue("Введите кординату X числа B");
int yb2 = getUserValue("Введите кординату Y числа B");
int zb2 = getUserValue("Введите кординату Z числа B");

double GetDist(int xa, int ya, int za, int xb, int yb, int zb)
{
    double dx = xa - xb;
    double dy = ya - yb;
    double dz = za - zb;

    return Math.Sqrt(dx * dx + dy * dy + dz * dz);
}

double result = GetDist(xa1, ya1, za1, xb2, yb2, zb2);
Console.WriteLine($"Расстояние между точками A ({xa1}, {ya1}, {za1}) и B ({xb2}, {yb2}, {zb2}) равно {Math.Round(result, 2)}");