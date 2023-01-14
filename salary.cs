using System;

namespace pro1
{
	class programm
	{
	 	 public static void Main(string[] args)
		 {
			string nam;
			int yr,sal;
			double ta,da,hra,cca,pf,ecpf,ma,ps,th;
			Console.Write("ENTER THE NAME OF THE WORKER :");
			nam=Console.ReadLine();
			Console.Write("ENTER THE AGE OF THE WORKER :");
			yr=int.Parse(Console.ReadLine()); 
			Console.Write("ENTER THE BASIC SALARY OF THE WORKER :");
			sal=int.Parse(Console.ReadLine());
			ta=(10*sal)/100;
			da=(50*sal)/100;
			hra=(15*sal)/100;
			cca=150;
			pf=(12*sal)/100 ;
			ecpf=(8.25f*sal)/100 ;
			ma=(2.5*sal)/100;
			ps=(3.75*sal)/100;
			th=sal+ta+da+hra+cca-(pf+ecpf+ps+ma);
			Console.WriteLine("==============================================");
			Console.WriteLine("THE NAME OF THE WORKER             IS : {0} ",nam);
			Console.WriteLine("THE AGE OF THE WORKER              IS : {0} ",yr);
			Console.WriteLine("THE TA OF THE WORKER               IS : {0}",ta);
			Console.WriteLine("THE DA OF THE WORKER               IS : {0}",da);
			Console.WriteLine("THE HRA OF THE  WORKER             IS : {0}",hra);
			Console.WriteLine("THE CCA OF THE WORKER              IS : {0}",cca);
			Console.WriteLine("THE PF OF THE WORKER               IS : {0}",pf);
			Console.WriteLine("THE ECPF-1 OF THE WORKER(pf)       IS : {0}",ecpf);
			Console.WriteLine("THE ECPF-2 OF THE WORKER(pension scheme) IS : {0}",ps);
			Console.WriteLine("THE MA OF THE WORKER               IS :  {0}",ma);
			Console.WriteLine("TAKE HOME SALARY =  BASIC SALARY + TA  + DA  + HRA + CCA - PF  - ECPF-1 - ECPF-2 - MA");
			Console.WriteLine("{0}             =       {1}     + {2} + {3} + {4} + {5} - {6} - {7}    - {8}    - {9}",th,sal,ta,da,hra,cca,pf,ecpf,ps,ma);          
			Console.WriteLine("THE TAKE HOME SALARY OF THE WORKER IS :{0} RS.",th);
			Console.WriteLine("==============================================");
			Console.ReadLine();
			}
	 }
}