// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

Console.WriteLine("введите x1");
var x1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y1");
var y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z1");
var z1 = int.Parse(Console.ReadLine());

Console.WriteLine("введите x2");
var x2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y2");
var y2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z2");
var z2 = int.Parse(Console.ReadLine());

double Distance(int x1Local, int y1Local, int z1Local, int x2Local, int y2Local, int z2Local)
{
    var d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0);
    return d;
}

Console.WriteLine($"Расстояние между точками: {Distance(x1, y1, z1, x2, y2, z2)}");