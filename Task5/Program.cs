// Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


int number1 = GetInteger("Введите первое число: ");
int number2 = GetInteger("Введите второе число: ");

if (IsSquare(number1, number2))
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
else if (IsSquare(number2, number1))
    Console.WriteLine($"Число {number2} является квадратом числа {number1}");
else
    Console.WriteLine($"Ни одно из чисел {number1} и {number2} не является квадратом другого");

int GetInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool IsSquare(int num1, int num2)
{
    return num1 == num2 * num2;
}
