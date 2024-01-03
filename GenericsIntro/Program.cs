// See https://aka.ms/new-console-template for more information
using GenericsIntro;

Console.WriteLine("Hello, World!");

static void Main(string[] args)
{
    Mylist<string> names = new Mylist<string>();

    names.Add("Berkay");
    Console.WriteLine(names);
}