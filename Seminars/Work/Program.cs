﻿// Ввод чисел

// Console.Clear(); // очистка консоли
// int n = Convert.ToInt32(Console.ReadLine());
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n * 3);
// ctrl + / - комментирование и раскомментирование
/*
программный код
Hello, world!
*/

// Необходимо спросить у пользователя 2 числа и узнать, какое из них наибольшее.
// 1 > 2
// 2 > 1
// 1 = 2
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// // Интерполяция строк
// // Console.WriteLine($"Результат {a} + {b} = {a + b}");
// // Console.WriteLine("Результат " + a + " + " + b + " = " + (a + b));
// // Console.WriteLine(a > b);
// if (a > b) 
//     Console.WriteLine(a);
// else if (a < b)
//     Console.WriteLine(b);
// else
//     Console.WriteLine("=");

// for (begin; end; step)
// i++ <=> i = i + 1
// for(int i = 1; i <= 10; i++) // 1 2 3 4 5 6 7 8 9 10 
//     Console.Write($"{i} ");
// Console.WriteLine();
// for(int i = 1; i <= 10; i+=2) // 1 3 5 7 9
//     Console.Write($"{i} ");
// Console.WriteLine();
// for(int i = 10; i > 0; i--) // 10 9 8 7 6 5 4 3 2 1
//     Console.Write($"{i} ");

// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4  -> 16 
// -3 -> 9 
// -7 -> 49

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n * n);

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

//моя

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
//   if (a * a == b)
//       Console.WriteLine("True");
//   else
//       Console.WriteLine("False");

//Учителя

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
if (m * m == n)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница