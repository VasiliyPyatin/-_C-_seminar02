// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;
using static System.Console;

Clear();


WriteLine("Введите цифру обозначающую день недели");
int day = Convert.ToInt32(ReadLine());

if (day > 7 || day < 1)
{
    WriteLine("Такого дня недели не существует");
    return;
}

if (day==1) WriteLine ("нет");
if (day==2) WriteLine ("нет");
if (day==3) WriteLine ("нет");
if (day==4) WriteLine ("нет");
if (day==5) WriteLine ("нет");
if (day==6) WriteLine ("да");
if (day==7) WriteLine ("да");

