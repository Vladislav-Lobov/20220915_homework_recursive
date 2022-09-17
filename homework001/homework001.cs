//0001 Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

int[] GetNextNumber(int m, int n, int[] array, int i = 0)
{
    if (n - m <= i)
    {
        return array;
    }
    array[i] = i + m;
    GetNextNumber(m, n, array, i + 1);
    return array;
}


void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    };
};




Console.WriteLine("Введите число m ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите число n ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || m < 1 || !isNumberN || n < 1 || m > n)
{
    Console.WriteLine("Неверный ввод");
    return;
};

n++;
int[] newArray = new int[n - m];
newArray = GetNextNumber(m, n, newArray);
PrintArr(newArray);
