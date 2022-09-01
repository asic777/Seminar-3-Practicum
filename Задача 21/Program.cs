// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21. Нахождение расстояния между двумя точками в трехмерном пространстве");

Console.Write("Введите координату X первой точки: ");
double firstPointX = System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double firstPointY = System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double firstPointZ = System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
double secondPointX = System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double secondPointY = System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double secondPointZ = System.Convert.ToDouble(Console.ReadLine());

// double firstPointX = 3;
// double firstPointY = 6;
// double firstPointZ = 8;
// double secondPointX = 2;
// double secondPointY = 1;
// double secondPointZ = -7;

// double firstPointX = 7;
// double firstPointY = -5;
// double firstPointZ = 0;
// double secondPointX = 1;
// double secondPointY = -1;
// double secondPointZ = 9;

double result = Math.Sqrt(
Math.Pow(secondPointX - firstPointX, 2) +
Math.Pow(secondPointY - firstPointY, 2) +
Math.Pow(secondPointZ - firstPointZ, 2)
);

Console.WriteLine("Расстояние между точками = {0:F}",result);
