// Напишите программу, которая на вход принимает число (N), а на выходе 
//показывает все чётные числа от 1 до N.
//5 -> 2, 4
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (number < 0) Console.WriteLine("Вы ввели отрицательное число.");
else
if (number == 1) Console.WriteLine("Четных чисел нет.");
else
do 
{
 if (i % 2 == 0) Console.WriteLine("Четное число: " + i);
 i = i + 1; 
}
while (i < number);