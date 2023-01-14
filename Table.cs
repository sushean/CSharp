using System;
namespace program
{
	class Table
		{
			public static void Main(String []args)
			{
				int i;
				for(i=0;i<args.Length;i++)
				{
					Console.WriteLine("{0}."+"["+args[i]+"]",i+1);
				}
			}
		}
}