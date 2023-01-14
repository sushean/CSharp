using System;
namespace Loop
{
	class Loops
	{
		public static void Main()
		{
		int i,lim,j=1;
		Console.Write("ENTER THE NUMBER TO GENERATE TABLE OF : ");
		i=int.Parse(Console.ReadLine());
		Console.Write("ENTER THE LIMIT OF TABLE : ");
		lim=int.Parse(Console.ReadLine());
		while(j<=lim)
			{

				Console.WriteLine("{0} X {1}  = {2} ",i,j,(i*j));
				j++;
			}
		Console.ReadLine();
		}
	}
}
		