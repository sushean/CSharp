using System;
namespace forloop
{
	class forloop1
	{
		public static void Main(string[] args)
		{
			int male=0,female=0;
			string[] gender = {"Male","Female","Male","Female","Male","Female","Male","Male","Male","Female","Male","Female"};
			foreach(string x in gender)
			{
				if(x=="Male")
					male++;
				else
					female++;
			}
			Console.WriteLine("Total No. of Male is : " +male);
			Console.WriteLine("Total No. of Female is : " +female);
		}
	}
}