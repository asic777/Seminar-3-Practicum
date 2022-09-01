// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 23. Таблица кубов чисел от 1 до N");

Console.Write("Введите число N: ");
int number = System.Convert.ToInt32(Console.ReadLine());

//Проверка ввода
if (number < 1)
{
    Console.WriteLine("Число N должно быть от 1 и больше.");
    return;
}

string result = "1";
int index = 2;
while (index <= number)
{
    result = result + ", " + Math.Pow(index, 3);
    index++;
}

Console.WriteLine("{0} -> {1}", number, result);