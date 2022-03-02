// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Random rnd = new Random();
int value = rnd.Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {value}");
Console.WriteLine($"Удалив вторую цифру получаем {value / 100}{value % 10}");