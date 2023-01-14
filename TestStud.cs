using System;
namespace Mynamespace1
{
	internal class StudClass
	{
		string Sname,Saddr;
		int rollno,age;
		double Marks;
		void getData()
		{
			Console.Write("ENTER STUDENT NAME    :");
			Sname=Console.ReadLine();
			Console.Write("ENTER STUDENT AGE     :");
			age=int.Parse(Console.ReadLine());
			Console.Write("ENTER STUDENT ADDRESS :");
			Saddr=Console.ReadLine();
			Console.Write("ENTER STUDENT ROLLNO. :");
			rollno=int.Parse(Console.ReadLine());
			Console.Write("ENTER STUDENT MARKS   :");
			Marks=double.Parse(Console.ReadLine());
		}
		void showData()
		{
			Console.WriteLine("=======================================");
			Console.WriteLine("STUDENT NAME    :"+Sname);
			Console.WriteLine("STUDENT ROLLNO  :"+rollno);
			Console.WriteLine("STUDENT AGE     :"+age);
			Console.WriteLine("STUDENT ADDRESS :"+Saddr);
			Console.WriteLine("STUDENT MARKS   :"+Marks);
			Console.WriteLine("=======================================");
		}
	}
	class TestStud
		{
			public static void Main()
			{
				StudClass sc = new StudClass();
				sc.getData();
				sc.showData();
			}
		}
}