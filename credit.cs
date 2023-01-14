using System;
public class CreditCard
{
	public static void Main()
	{
		double salary;
		int CreditRating;

		Console.WriteLine("What is your annual salary");
		salary=Convert.ToDouble(Console.ReadLine());//it does not mainati the accuray but parse does

		Console.WriteLine("On a Scale of 1 through 10,What is your credit rating");
		CreditRating=Convert.ToInt32(Console.ReadLine());

		if(salary >= 20000 && CreditRating>=7)
		{
			Qualify();

		}
		else
		{
			Noqualify();
		}
	}
	
	public static void Qualify()
		{
			Console.WriteLine("You Qualify");

		}
	public static void Noqualify()
		{
			Console.WriteLine("You are not Qualified");
		}
}