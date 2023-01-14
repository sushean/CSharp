using System;
namespace Programm
{
	class Test2
	{
		public static void Main(String[] args)
		{
		string a,b,c,d,e;
		Console.Write("ENTER THE NAME OF STUDENT             :");
		a=Console.ReadLine();
		Console.Write("ENTER THE ROLL NO. OF THE STUDENT     :");
		b=Console.ReadLine();
		Console.Write("ENTER THE CLASS OF STUDENT            :");
		c=Console.ReadLine();
		Console.Write("ENTER THE PHONE NUMBER OF THE STUDENT :");
		d=Console.ReadLine(); 
		Console.Write("ENTER THE AGE OF THE STUDENT          :");
		e=Console.ReadLine();
		Console.WriteLine("=====================================");
		Console.WriteLine("THE NAME OF STUDENT     IS     {0}",a);
		Console.WriteLine("THE ROLL NO. OF STUDENT IS     {0}",b);
		Console.WriteLine("THE AGE OF STUDENT      IS     {0}",e);
		Console.WriteLine("THE CLASS OF STUDENT    IS     {0}",c);
		Console.WriteLine("THE PHONE NUMBER OF STUDENT IS {0}",d);
		Console.WriteLine("=====================================");
		Console.ReadLine();
		}
	}
}
