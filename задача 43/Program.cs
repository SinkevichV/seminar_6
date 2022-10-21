/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/



int GetValue(string message)
{
    {
        Console.WriteLine(message);
        int value = int.Parse(Console.ReadLine() ?? "");
        return value;
    }
}

double b1 = GetValue("Введите значение b1:");
double k1 = GetValue("Введите значение k1:");
double b2 = GetValue("Введите значение b2:");
double k2 = GetValue("Введите значение k2:");

if (k1 != k2)
{
    double X = (b2 - b1) / (k1 - k2);
    double Y = k1 * X + b1;
    Console.WriteLine($"координаты пересечения двух прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 = ({X};{Y})");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine($"прямые заданные уравнениями y = k1 * x + b1, y = k2 * x + b2: совпадают и имеют множество точек пересечения");
}

else
    Console.WriteLine($"прямые заданные уравнениями y = k1 * x + b1, y = k2 * x + b2 не пересекаются");



