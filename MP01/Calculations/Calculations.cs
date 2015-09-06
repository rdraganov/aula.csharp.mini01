using System;

namespace Calculations
{
	public class MainLibrary
	{
		public Formula01 F01= new Formula01();
		public Formula02 F02= new Formula02();
		public Formula03 F03= new Formula03();
		public Formula04 F04= new Formula04();
		public Formula05 F05= new Formula05();


		Colors.ForCLI _cl = new Colors.ForCLI();
		public MainLibrary ()
		{
		}

		/// <summary>
		/// Информация за действащите функционалности на програмата
		/// </summary>
		public void commands ()
		{
			_cl.Default (); Console.Write (" Налични команди: \n");
			_cl.Command (); Console.Write ("[яма]");
			_cl.Default (); Console.WriteLine (" - пресмятане обема на строителна яма");
			_cl.Command (); Console.Write ("[въгъл]");
			_cl.Default (); Console.WriteLine (" - пресмятане обема на вдлъбнат ъгъл");
			_cl.Command (); Console.Write ("[иъгъл]");
			_cl.Default (); Console.WriteLine (" - пресмятане обема на изпъкнал ъгъл");
			_cl.Command (); Console.Write ("[откос]");
			_cl.Default (); Console.WriteLine (" - пресмятане обема на откоса на изкоп");
			_cl.Command (); Console.Write ("[канал]");
			_cl.Default (); Console.WriteLine (" - пресмятане обема на канален изкоп\n");
			_cl.Command (); Console.Write ("[помощ] / [-п]");
			_cl.Default (); Console.WriteLine (" - помощ за наличните команди");
			_cl.Command (); Console.Write ("[изчисти] / [-и]");
			_cl.Default (); Console.WriteLine (" - изчистване на екрана");
			_cl.Command (); Console.Write ("[изход]");
			_cl.Default (); Console.WriteLine (" - изход от програмата\n");


		}
	}
}

