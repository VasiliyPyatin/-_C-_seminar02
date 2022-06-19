// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

using System;
using static System.Console;

Clear();


WriteLine("Введите число");
int N = Convert.ToInt32(ReadLine());

int a3 = N / 100;

// if (a3 > 0)
// {
//     WriteLine (a3%10);
// }
// else
// {
//     WriteLine ("третьей цифры нет");
// }


string answer = a3 > 0 ?$"Третья цифра {a3%10}" : "третьей цифры нет";
WriteLine (answer);

