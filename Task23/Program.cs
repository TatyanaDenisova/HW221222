﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int getUserValue (string message)
{
    Console.WriteLine(message);
    int resalt = int.Parse(Console.ReadLine()!);
    return resalt;
}
void kub (int N)
{
    for (int i = 1; i < N + 1; i++)
{
    int temp = i*i*i;
    if(i < N)
    {
        Console.Write($" {temp},");
    }
    else
    {
        Console.Write($" {temp}");
    }
}
}
int N = getUserValue("Введите число N:");
kub(N);