// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

int n = 5;

NumberRec(n);
void NumberRec(int num, int start = 1)
{
    if (start <= num)
    {
        Console.Write(start);
        if (start != num)
            Console.Write(",");
        else
            Console.Write(".");
        NumberRec(num, start + 1);
    }
}
