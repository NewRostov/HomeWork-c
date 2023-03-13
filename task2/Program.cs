// Напишите программу, которая принимает 
//на вход три числа и выдаёт максимальное из этих чисел
Console.Write("Введите целое число (можно отрицательное) a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число (можно отрицательное) b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число (можно отрицательное) c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;

{Console.WriteLine( " Максимальное число max = " + max + "; " + "a = " + a + "; " + "b = " + b + "; " + "c = " + c + ";" );}

