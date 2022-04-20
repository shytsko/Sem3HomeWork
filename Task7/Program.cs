// Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

Console.WriteLine("Введите что угодно. для выхода введите exit");
while(true)
{
    Console.Write("> ");
    string inputString = Console.ReadLine();
    if(inputString == "exit" || inputString == "Exit")
        break;
}
