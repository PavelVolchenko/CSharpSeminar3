/*  Задача 18: Напишите программу, которая по 
    заданному номеру четверти, показывает диапазон 
    возможных координат точек в этой четверти (x и y).  */

int getQuarterFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation}: ");
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1 || result > 4)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число от 1 до 4. {userInformation}: ");
    }
    return result;
}

string getCoordinateRangeFromQuarter(int quarterNumber)
{
    string result = "";
    if(quarterNumber == 1)
    {
        result = "X > 0, Y > 0";
    }
    else if(quarterNumber == 2)
    {
        result = "X > 0, Y < 0";
    }
    else if(quarterNumber == 3)
    {
        result = "X < 0, Y < 0";
    }
    else if(quarterNumber == 4)
    {
        result = "X < 0, Y > 0";
    }
    else result = "Ошибка ввода";
    return result;
}

int userQuarterNumber = getQuarterFromUser("Введите число от 1 до 4");
Console.WriteLine(getCoordinateRangeFromQuarter(userQuarterNumber));