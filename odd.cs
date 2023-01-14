using System;
namespace Loop
{
	class Loops
	{
		public static void Main()
		{
			int i=1;
			while(i<=100)
			{
				if(i%2!=0)
				{
					Console.Write(i + " ");
			
				}
				i++;
			}
			Console.WriteLine();
			Console.WriteLine("============================================================");
			Console.WriteLine("CONTROL IS OUT OF LOOP NOW ");
		}
	}
}