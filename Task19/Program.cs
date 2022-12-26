// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int getUserValue(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GetPaliandrDigit(int number)
{
    int digit5 = number % 10;
    int digit1 = number / 10000;
    int digit4 = number /10 % 10;
    int digit2 = number / 1000 - digit1*10;
    if (digit1 == digit5 && digit2 == digit4)
    {
            Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
    return number;
}
int number = getUserValue("Введите пятизначное число");
GetPaliandrDigit(number);
