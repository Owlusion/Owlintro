// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



    Add();
    Add();
    Add();
    Add();
    Add();
    var result = Add2(62);
    Console.WriteLine(result);

//Console.ReadLine();

static void Add()
{
    Console.WriteLine("Added!");
}

static int Add2(int num1, int num2 = 15)
{
    var result = num1 + num2;
    return result;
}