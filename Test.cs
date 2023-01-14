using System;
namespace test
{
class Test1
{
public static void Main(String[] args)
{
int num1,num2;
Console.Write("ENTER THE FIRST NUMBER :");
num1=int.Parse(Console.ReadLine());
Console.Write("ENTER THE SECOND NUMBER :");
num2=int.Parse(Console.ReadLine());
Console.WriteLine("=======================================");
Console.WriteLine("The sum of two numbers is :"+(num1+num2));
Console.ReadLine();
}
}
} 