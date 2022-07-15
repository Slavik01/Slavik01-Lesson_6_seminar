//  Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayNumber = new int [number];
int count = 0;

for (int i = 0; i < arrayNumber.Length; i++)
{
    arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
    if (arrayNumber[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Чисел больше 0 было введено: {count}");

