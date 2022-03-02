// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число, обозначающее день недели => ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);
if (A > 7) Console.WriteLine("Неверно указан день недели: в неделе 7 дней");
else
if (A < 6) Console.WriteLine("Рабочий день");
else Console.WriteLine("Выходной");