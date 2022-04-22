// **Задача 14**. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int number = GetInteger();

string result;
if(IsМultiples(number, 7) && IsМultiples(number, 23))
    result = "кратно";
else
    result = "не кратно";

Console.WriteLine($"Число {number} {result} одновременно 7 и 23");

int GetInteger()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsМultiples(int number1, int number2)
{
    return number1 % number2 == 0;
}
