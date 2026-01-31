using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
Console.WriteLine("Uyutov Pavel Alexsandrovich");
Console.WriteLine(DateTime.Now);

string name = Console.ReadLine();
Console.WriteLine($"привет, {name}");
Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine("продолжить? (y/n)");
string answer = Console.ReadLine();

if(answer.ToLower() == "y" || answer.ToLower() == "у"){
    Console.WriteLine("продолжаем");
}else
{
    Console.WriteLine("не продолжаем");
}

