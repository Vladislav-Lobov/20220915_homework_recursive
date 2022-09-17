//0002 Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.



int GetSumOfNumbers(int m, int n, int sum = 0)
{
    if (m > n)
    {
        return sum;
    }
    return sum + m + GetSumOfNumbers(m + 1, n, sum);
}



Console.WriteLine("Введите число m ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите число n ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || m < 1 || !isNumberN || n < 1 || m > n)
{
    Console.WriteLine("Неверный ввод");
    return;
};

Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна: {GetSumOfNumbers(m, n)}");

