using System;
namespace ToiletSoap
{
	internal class Soap
	{
		internal string Brand , type ;
		internal int quant ;
		internal static double price = 25;
		
		internal void setData(string Brand , string type,int quant)
		{
			/*Console.Write("ENTER SOAP BRAND : ");
			Brand=Console.ReadLine();
			Console.Write("ENTEER SOAP TYPE : ");
			type=Console.ReadLine();
			Console.Write("ENTER QUANTITY OF SOAP : ");
			quant=int.Parse(Console.ReadLine());*/
			this.Brand=Brand;
			this.quant=quant;
			this.type=type;
		}
		
		internal void putData()
		{
			Console.WriteLine("=========================================");
			Console.WriteLine("BRAND OF SOAP IS              : "+Brand);
			Console.WriteLine("TYPE OF THE SOAP IS           : "+ type);
			Console.WriteLine("QUANTITY OF THE SOAP IS       : "+quant);
			Console.WriteLine("THE PRICE OF 1 SOAP IS        : "+price);
			Console.WriteLine("TOTAL COST OF {0} IS            : {1}",quant,(quant*price));
			Console.WriteLine("=========================================");
		}
	}
	class TestSoap
	{
		static void Main()
		{
			Soap s = new Soap();
			Soap s1 = new Soap();
			Soap s2 = new Soap();
			s.setData("LUX","LIME",5);
			s1.setData("LUX","ROSE",6);
			s2.setData("LUX","MINT",7);
			s.putData();
			s1.putData();
			s2.putData();
		}
	}
}