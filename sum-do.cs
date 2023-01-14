using System;
namespace loop
{
	class loops
	{
		public static void Main()
		{
		int i,sum=0,rem;
		Console.Write("ENTER ANY NUMBER :  ");
		i=int.Parse(Console.ReadLine());
		do
		{
		rem=i%10;
		i=i/10;
		sum=sum+rem;
		}while(i>0);
		Console.Write("{0} ",sum);

		}
	}
}