// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 з
// адаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите 1 число: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 4 число: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double result = (b2 - b1)/(k1 - k2);

Console.Write("Точка пересечения: " + result);
