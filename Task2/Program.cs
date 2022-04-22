// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double xA = GetCoordinate("A", "x");
double yA = GetCoordinate("A", "y");
double zA = GetCoordinate("A", "z");
double xB = GetCoordinate("B", "x");
double yB = GetCoordinate("B", "y");
double zB = GetCoordinate("B", "z");

double distance = sqrt(pow(xA - xB, 2) + pow(yA - yB, 2) + pow(zA - zB, 2));

Console.WriteLine($"Расстояние между точками A и B: {distance}");

double GetCoordinate(string pointName, string coordinateName)
{
    Console.Write($"Введите координату {coordinateName} точки {pointName}: ");
    return Convert.ToDouble(Console.ReadLine());
}

// Функция возвращает абсолютное значение вещественного числа x
double abs(double value)
{
    if (value < 0)
        return -value;
    return value;
}

// Функция возводит вещественное число x в степень p. Степени только целые положительные
double pow(double value, int powValue)
{
    double result = value;
    powValue--;
    while (powValue > 0)
    {
        result *= value;
        powValue--;
    }

    return result;
}

// Функция возвращает квадратный корень вещественного числа x
double sqrt(double value)
{
    double result = value / 2; // Приблизительное начальное значение результата

    double accuracy = 0.000000000000001; //точность

    double error = double.MaxValue;
    while (error > accuracy) // Пока не достигнута нужная точность
    {
        double resultNew = (result + value / result) / 2; // Уточняем результат (формула Ньютона)
        error = abs(result - resultNew); // Вычисляем ошибку (на сколько изменился новый результат по сравнению с предыдущим)
        result = resultNew;
    }

    return result;
}
