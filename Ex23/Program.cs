﻿// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

void getCube(int n)
{
Console.WriteLine($"Таблица кубов для числа: {n}");
for (int i = 1; i <= n; i++){
Console.WriteLine(Math.Pow(i,3));
}

}

getCube(n);