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