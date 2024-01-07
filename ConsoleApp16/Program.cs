int number1 = int.Parse(Console.ReadLine());
string znak = Console.ReadLine();
int number2 = int.Parse(Console.ReadLine());
if (znak== "+")
{
    sum(number1, number2);
}
else if(znak == "-")
{
    devide(number1, number2);
}
else if(znak == "*")
{
    times(number1, number2);
}
else if(znak == "/")
{
    devide2(number1, number2) ;
}
else
{
    Console.WriteLine("try again");
}
static void sum(double n1, double n2)
{
    int sum = (int)(n1 + n2);
    Console.WriteLine(sum);
}
static void devide(double n1, double n2)
{
    int devide = (int)(n1 - n2);
    Console.WriteLine(devide);
}
static void times(double n1, double n2)
{
   
    int sum = (int)(n1 * n2);
    Console.WriteLine(sum);
}
static void devide2(double n1, double n2)
{
   int devide2 = (int)(n1 / n2);
    Console.WriteLine(devide2);
}
Console.WriteLine("hubav den");