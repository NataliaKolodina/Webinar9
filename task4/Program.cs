// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)



Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!)!;
Console.WriteLine(RecursPow(a, b));

int RecursPow(int num1, int num2)
{
    if (num2 == 1)
    {
        return num1;
    }
    else
    {
        return num1 * RecursPow(num1, num2 - 1);
    }
}
