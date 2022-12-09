// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Напишите число");
int a = int.Parse(Console.ReadLine());
if (a < 0)
{
    a = a * -1;
}
while (a >= 1000)
{    a = a / 10;
}

if (a >= 100)
{
    int mod = a % 10;
    //write end number now is 8writinig all number
    Console.WriteLine($"int Mod {mod}");
}

if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
