// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6, 7 - выходной.
//НО дня с индексом 0 или 12 не существует.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Напишите число дня недели");
int a = int.Parse(Console.ReadLine());
if (a < 6)
{
    Console.WriteLine("doesn't exist");
}
if (a == 7)
{
    Console.WriteLine("yes");
}
if (a == 6)
{
    Console.WriteLine("yes");
}
if (a > 7)
{
    Console.WriteLine("no");
}