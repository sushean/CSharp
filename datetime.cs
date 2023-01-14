using System;
using System.Text;

	class Program
	{
		static void  Main()
		{
		
			DateTime curDt = DateTime.Now;
			Console.WriteLine("--> d: Short date pattern: {0:d}",curDt);
			Console.WriteLine("--> D: Long date pattern : {0:D}",curDt);
			Console.WriteLine("--> f: Full date/time (short) pattern : {0:f}",curDt);
			Console.WriteLine("--> F: Full date/time (long) pattern : {0:F}",curDt);
			Console.WriteLine("--> g: General date/time (short time) pattern : {0:g}",curDt);
			Console.WriteLine("--> G: General date/time (long time)  pattern :{0:G}",curDt);
			Console.WriteLine("--> M: Month day pattern : {0:M}",curDt);
			Console.WriteLine("--> m: Month day pattern : {0:m}",curDt);
			Console.WriteLine("--> Y: Year month pattern : {0:Y}",curDt);
			Console.WriteLine("--> y: Year month pattern : {0:y}",curDt);
			Console.WriteLine("--> t: short time pattern : {0:t}",curDt);
			Console.WriteLine("--> T: Long time pattern :  {0:T}",curDt);
			Console.WriteLine("--> s: Universal local date-time pattern : {0:s}",curDt);
			Console.WriteLine("--> u: Universal  Date-time pattern : {0:u}",curDt);
			Console.WriteLine("--> U: Universal Time pattern : {0:U}",curDt);
			Console.ReadLine();
	 	}
	}