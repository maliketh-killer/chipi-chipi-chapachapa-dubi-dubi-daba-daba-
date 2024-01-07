Console.WriteLine("summing? deviding? timing? deviding 2?");
string a = Console.ReadLine();
if (a== "summing")
{
    add();
}
else if(a == "deviding")
{
    substract();
}
else if(a == "timing")
{
    times();
}
else if(a == "deviding 2")
{
    devide();
}
else
{
    Console.WriteLine("try again");
}
static void add()
{
    Console.WriteLine("enter num1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter num2: ");
    int num2 = int.Parse(Console.ReadLine());
    int sum = num1 + num2;
    Console.WriteLine(sum);
}
static void substract()
{
    Console.WriteLine("enter num1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter num2: ");
    int num2 = int.Parse(Console.ReadLine());
    int devide = num1 - num2;
    Console.WriteLine(devide);
}
static void times()
{
    Console.WriteLine("enter num1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter num2: ");
    int num2 = int.Parse(Console.ReadLine());
    int sum = num1 * num2;
    Console.WriteLine(sum);
}
static void devide()
{
    Console.WriteLine("enter num1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("enter num2: ");
    int num2 = int.Parse(Console.ReadLine());
    int sum = num1 / num2;
    Console.WriteLine(sum);
    }
Console.WriteLine("nqkva glupost");