//0003 Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.

ulong Akkerman(ulong m, ulong n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}







Console.WriteLine("Введите число m ");
bool isNumberM = ulong.TryParse(Console.ReadLine(), out ulong m);

Console.WriteLine("Введите число n ");
bool isNumberN = ulong.TryParse(Console.ReadLine(), out ulong n);

if (!isNumberM || m < 0 || !isNumberN || n < 0)
{
    Console.WriteLine("Неверный ввод");
    return;
};

Console.WriteLine($"Функция Аккермана для m={m} и для n={n} равна: {Akkerman(m, n)}");

