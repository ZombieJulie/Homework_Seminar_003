// Задача 19. Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
var number = Console.ReadLine();

void PalindromCheck(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
        Console.WriteLine($"Число {number} палиндром");
    else
        Console.WriteLine($"Число {number} не палиндром");
}

if (number.Length == 5)
    PalindromCheck(number);
else
    Console.WriteLine("Введено не пятизначное число: ");