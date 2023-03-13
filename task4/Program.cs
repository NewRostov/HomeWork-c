// Напишите программу, которая на вход принимает число (N), а на выходе 
//показывает все чётные числа от 1 до N.
//5 -> 2, 4
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;

if (number == 0) Console.WriteLine("Вы ввели ноль.");
if (number == 1) Console.WriteLine("Четных чисел нет.");
do 
{
 i = i + 1; 
 if (i % 2 == 0) Console.WriteLine("Четное число: " + i);
}
while (i < number);