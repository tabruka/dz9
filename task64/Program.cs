/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Hello, World!");
*/


Console.WriteLine("Введите число больше 0");
int number = int.Parse(Console.ReadLine());
Rec(number);

void Rec(int number)
{
    Console.Write(number);
    if(number <= 1)
    {
        return;
    }
    Console.Write(", ");
    Rec(number - 1);
    return;
}