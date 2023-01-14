using System;
namespace forloop
{
	class forloop1
	{
		public static void Main(String[] args)
		{
			int i=0, male=0,female=0;
			string[] gender = {"Male","Female","Male","Female","Male","Female","Male","Male","Male","Female","Male","Female"};//[]-subscript holder
			for(i=0;i<gender.Length;i++)
				{
					if(gender[i]=="Male")
						male++;
					else
						female++;
				}
			Console.WriteLine("Total No. of Male is : " +male);
			Console.WriteLine("Total No. of Female is : " +female);
			Console.WriteLine(i);
		}
	}
}
			