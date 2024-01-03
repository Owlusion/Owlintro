// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");


string[] courses = new string[]
{
    "course_one",
    "course_two",
    "course_three",
    "course_four",
    "course_five"
};

int cl = courses.Length;
//Console.WriteLine(cl);

for (int i = 0; i < cl; i++) //i++
{
    Console.WriteLine(courses[i]);
}
Console.WriteLine("EndOfFor");

foreach (string course in courses)
{
    Console.WriteLine(course);
}