﻿// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) {Console.WriteLine( "Число " + number + " является отрицательным." );}
else
if (number % 2 == 0) 
{Console.WriteLine( "Число " + number + " является чётным." );}
else 
{Console.WriteLine( "Число " + number + " не является чётным." );}

