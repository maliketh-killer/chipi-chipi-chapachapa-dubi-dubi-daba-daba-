Console.WriteLine("Enter number 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2");
int num2 = int.Parse(Console.ReadLine());
int sum = num1 + num2;
int devide = num1 - num2;
int times = num1 * num2;
int devide2 = num1 / num2;
Console.WriteLine("summing? deviding? timing?? deviding 2????");
if (Console.ReadLine() == "summing")
{
    Console.WriteLine(sum);
}
else if(Console.ReadLine() == "deviding")
{
    Console.WriteLine(devide);
}
else if(Console.ReadLine() == "timing")
{
    Console.WriteLine(times);
}
else if(Console.ReadLine() == "deviding 2")
{
    Console.WriteLine(devide2);
}
else
{
    Console.WriteLine("try again");
}
