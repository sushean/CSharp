using System;
namespace programm
{
	class Fibbonacci
	{
		public static void  Main(string []args)
		{
			int a=0 , b=1 ,c=0;
			while(a<=int.Parse(args[0]))
			{
				Console.Write(a+" ");
				c=a+b;
				a=b;
				b=c;
			}
		}
	}
}