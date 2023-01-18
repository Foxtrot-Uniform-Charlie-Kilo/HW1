// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int r1 = (num / 10)%10;

{
    Console.WriteLine(r1);
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string S1 = Convert.ToString(num);
int S2 = S1.Length;
if (S2 > 2)
{
    Console.WriteLine($"Третья цифра введённого числа: {S1[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


System.Console.WriteLine("Введите число, соответствующую дню недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 5 && num < 8)
{
    Console.WriteLine("Поздравляем, у вас выходной");
}
if (num > 7)
{
    Console.WriteLine("Нельзя ввести число больше 7");
}
else
{
    Console.WriteLine("Нет, иди работай :(");
}
