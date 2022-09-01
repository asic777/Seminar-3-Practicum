// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Задача 19. Проверка числа на палиндром");

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

//Проверка ввода
if (number < 10000 || number > 99999)
{
    Console.WriteLine($"Число {number} - не является пятизначным.");
    return;
}

//Проверка на палиндром
if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
{
    Console.WriteLine($"Число {number} - палиндром.");
}
else
{
    Console.WriteLine($"Число {number} - не палиндром.");
}