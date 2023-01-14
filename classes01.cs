using System;
namespace Mynamespace
{
	class MyClass
	{
		string name,addr;
		int  roll,age;
		void input()
		{
			Console.Write("ENTER STUDENT NAME    :");
			name=Console.ReadLine();
			Console.Write("ENTER STUDENT AGE     :");
			age=int.Parse(Console.ReadLine());
			Console.Write("ENTER STUDENT ADDRESS :");
			addr=Console.ReadLine();
			Console.Write("ENTER STUDENT ROLL NO :");
			roll=int.Parse(Console.ReadLine());
		}
		void show()
		{
			Console.WriteLine("======================================");
			Console.WriteLine("STUDENT NAME IS    :"+name);
			Console.WriteLine("STUDENT AGE  IS    :"+age);
			Console.WriteLine("STUDENT ROLL NO IS :"+roll);
			Console.WriteLine("STUDENT ADDRESS IS :"+addr);
			Console.WriteLine("======================================");
		}
		static void Main()
		{
			MyClass my=new MyClass();
			my.input();
			my.show();

		}
	}
}