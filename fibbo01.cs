using System;
namespace Loop
{
	class Loops
	{
		public static void Main()
		{
			int i,fib1=0,fib2=1,c;
			Console.Write("ENTER THE LIMIT FOR THE FIBBONACI SERIES : ");
			i=int.Parse(Console.ReadLine());
  			while(fib1<=i)
			{
				Console.Write("{0}  ",fib1);
				c=fib1+fib2;
				fib1=fib2;
				fib2=c;
			}
		}
	}
}