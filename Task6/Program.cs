// В переменной string есть секретное сообщение, во второй есть пароль.
// Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

string secretMessage = "Секретное сообщение";

string password = "пароль";

Console.WriteLine("Введите пароль, чтобы прочитать секретное сообщение.");

int countTries = 3;

while (countTries > 0)
{
    Console.Write("> ");
    string inputPsw = Console.ReadLine();
    if (CheckPassword(password, inputPsw))
        break;
    else
    {
        Console.WriteLine("Пароль не верный.");
        countTries--;
    }
}

if (countTries > 0)
    Console.WriteLine(secretMessage);
else
    Console.WriteLine("Вы исчерпали допустимое количество попыток.");

bool CheckPassword(string setPassword, string userPassword)
{
    return userPassword == setPassword;
}
