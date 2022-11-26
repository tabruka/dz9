/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите неотрицательное число M");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine($"A({numberM}, {numberN}) = {Akkerman(numberM, numberN)}");

// Вычисление функции Аккермана

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    if (numberM > 0 && numberN == 0)
        return Akkerman(numberM - 1, 1);
    else
        return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
}