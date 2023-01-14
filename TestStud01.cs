using System;
namespace Mynamespace1
{
	class StudClass
	{
	string Sname,Saddr;
	int rollno, age;
	double Marks;
	internal void setData(string nm,string addr,string roll,string ag,string mark)
	//internal void setData(string nm,string addr,int roll,int ag,double mark)
		{
			Sname=nm;
			Saddr=addr;
			rollno=int.Parse(roll);
			//rollno=roll;
			age=int.Parse(ag);
			//age=ag;
			Marks=double.Parse(mark);
			//Marks=mark;
		}
	internal void showData()
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
	class TestStud01
	{
	public static void Main(string[] args)
		{
			StudClass sc = new StudClass();
			//sc.setData("Sushaen Sharma","309 Master Lane","21","18","99.99");
			//sc.setData("Sushaen Sharma","309 Master Lane",21,18,99.99);
			sc.setData(args[0],args[1],args[2],args[3],args[4]);
			sc.showData();
		}
	}
}