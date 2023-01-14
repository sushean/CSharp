using System;
namespace Loop
{
	class Loops
	{
		public static void Main()
		{
			int i=1,lim,j=1;
			char ch;
			while(i!=0)
				{
				j=1;
				Console.Write("ENTER THE TABLE YOU WANT TO GENERATE OF :  ");
				i=int.Parse(Console.ReadLine());
				Console.Write("ENTER THE LIMIT FOR THE TABLE           :  ");
				lim=int.Parse(Console.ReadLine());
					while(j<=lim)
						{
							Console.WriteLine("{0} X {1} = {2} ",i,j,(i*j));
							j++;
						}
				Console.Write("WANT TO ENTER AGAIN THEN ENTER Y OR N TO EXIT : ");
				ch=char.Parse(Console.ReadLine());
				if(ch=='n' || ch=='N')
					i=0;
				else if(ch=='y'  || ch=='Y')
				i=1;
				else
				i=0;
				}
		}
	}
}