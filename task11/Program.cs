//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.Write("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = int.Parse(Console.ReadLine());

double degree = Math.Pow(num1, num2);
Console.WriteLine(degree);