//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.Write("Введите целое число (можно отрицательное) a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число (можно отрицательное) b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b) 
{Console.WriteLine( " Число a = " + a + " и оно равно числу b = " + b );}
else 
if (a > b) 
{Console.WriteLine( " Максимальное число a = " + a + "; " + " Минимальное число b = " + b + "; " + "a > b;");}
else 
{Console.WriteLine( " Максимальное число b = " + b + "; " + " Минимальное число a = " + a + "; " + "b > a;");}
