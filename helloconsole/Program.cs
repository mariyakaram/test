// See https://aka.ms/new-console-template for more information
Console.WriteLine("4 Hello, World!");

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
// = - действие присвоение значения
// == - проверка на равенство
// != - проверка на неравенство
if (m * m == n) // ; ЗАПРЕЩЕНО
    Console.WriteLine("yes");
else
    Console.WriteLine("no"); 