// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = GetInteger();
int[] arrayCubs = GenerateArrayCubs(number);
PrintIntArray(arrayCubs);

int GetInteger()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArrayCubs(int n)
{
    int[] array = new int[n];

    int i = 1;
    while (i <= n)
    {
        array[i - 1] = i * i * i;
        i++;
    }

    return array;
}

void PrintIntArray(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
        i++;
    }
    Console.WriteLine();
}
