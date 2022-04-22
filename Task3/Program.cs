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

int[] GenerateArrayCubs(int length)
{
    int[] array = new int[length];

    int index = 1;
    while (index <= length)
    {
        array[index - 1] = index * index * index;
        index++;
    }

    return array;
}

void PrintIntArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.Write(array[index]);
        if (index != array.Length - 1)
            Console.Write(", ");
        index++;
    }
    Console.WriteLine();
}
