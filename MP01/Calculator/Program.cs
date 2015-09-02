using System;

namespace Calculator
{
	class MainClass
	{
		public UserInput.UInput uInput=new UserInput.UInput();
		public About.Me about=new About.Me();

		public static void Main (string[] args)
		{


			MainClass _program = new MainClass ();

			//форматиране на програмата
			Console.Title=_program.about.shortName+", "+ _program.about.version;

			_program.uInput.sayHello ();
			_program.uInput.getUserInput ();
		}
	}
}
