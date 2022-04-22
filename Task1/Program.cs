// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int number5Digit = GetInteger();

if (number5Digit > 9999 && number5Digit < 100000)
{
    string isOrIsNot;
    if (IsPalindrome(number5Digit))
        isOrIsNot = "является";
    else
        isOrIsNot = "не является";

    Console.WriteLine($"Число {number5Digit} {isOrIsNot} палиндромом");
}
else
{
    Console.WriteLine("Число должно быть пятизначным.");
}

int GetInteger()
{
    Console.Write("Введите пятизначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsPalindrome(int number)
{
    string str = Convert.ToString(number);
    return str[0] == str[4] && str[1] == str[3];
}
