// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;
using static System.Console;

Clear();

// int N=new Random().Next(100,1000);
// WriteLine($"Случайное число = {N}");

WriteLine("Введите трехзначное число");
int N = Convert.ToInt32(ReadLine());

//int a1 = N / 100;
int a2 = N / 10;
//int a3 = N % 10;

WriteLine (a2%10);