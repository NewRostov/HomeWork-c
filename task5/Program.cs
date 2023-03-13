//  Напишите программу, которая принимает на вход целое число любой разрядности и 
//на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет.
//Через строку решать нельзя.
//456111 -> 5
//78 -> 8
//9146548 -> 1
//3 -> нет
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10) { Console.WriteLine("Остатка нет"); } 
else if (number < 100) { Console.WriteLine(number % 10); }
else
{
do
{
 number = number/10;
}
while (number > 100);
Console.WriteLine(number % 10);;
}


