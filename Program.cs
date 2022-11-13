// See https://aka.ms/new-console-template for more information
using aula_Generics.Services;

PrintService<string> printService = new PrintService<string>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());



for (int i = 0; i < n; i++)
{
    string x = Console.ReadLine();
    printService.AddValue(x);
}

printService.Print();

System.Console.WriteLine("First: " + printService.First());