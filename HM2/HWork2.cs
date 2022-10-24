/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
int CenterNumber(int num)
{
    int result = num / 10 % 10;
    return result;
}
Console.Write("Input number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int secondDigit = CenterNumber(numberA);
Console.WriteLine($"Center digit of {numberA} is {secondDigit}.");
*/
/*

// Задача 13 (вариант 1): Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int TheThirdNumber(int num)
{
    int result;
    if (num <= 99)
        result = -1;
    else
    {
        while (num > 999)
            num = num / 10;
        result = num % 10;
    }
    
    return result;
}
Console.Write("Input number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int thirdDigit = TheThirdNumber(numberB);
if (thirdDigit > -1)
    Console.WriteLine($"Third digit of {numberB} is {thirdDigit}.");
else
    Console.WriteLine($"No third digit.");
*/
/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool DayOfTheWeek(int day)
{
    bool result;
    if (day == 6 ^ day == 7)
        result = true;
    else
        result = false;
    
    return result;
}
Console.Write("Input a number of the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
bool dayOfTheWeek = DayOfTheWeek(dayNumber);
if (dayOfTheWeek)
    Console.WriteLine($"Yes, the {dayNumber} day of the week is a holiday! :)");
else
    Console.WriteLine($"No, the {dayNumber} day of the week is not a holiday! :(");

/*
