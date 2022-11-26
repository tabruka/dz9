/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов от {numberM} до {numberN} = {SumNaturalDigit(numberM, numberN)}");

// Функция поиска суммы
int SumNaturalDigit (int numberM, int numberN)
{
    int sum = 0;
    if (numberM == numberN)
        return numberM;
    sum  = numberN + SumNaturalDigit(numberM, numberN - 1);
    return sum;
}