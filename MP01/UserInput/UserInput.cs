using System;

namespace UserInput
{
	public class UInput	
	{
		About.Me about = new About.Me ();
		Colors.ForCLI _c = new Colors.ForCLI();
		Calculations.MainLibrary _calc= new Calculations.MainLibrary();

		public UInput ()
		{

		}

		public void sayHello()
		{
			_c.Default ();
			Console.WriteLine ("Добре дошли в " + about.shortName + "\n" + about.version+"\n");
		}

		public void getUserInput ()
		{
			string _command="";

			do
			{
				_c.Prompt(); Console.Write("$ ");
				_c.Command(); _command=Console.ReadLine();

				//Проверка за налични команди
				if (_command.ToLower().Contains("яма")) _calc.F01.calc(_command);

				if (_command.ToLower().Contains("команда2")) 
				{
					_c.Default(); Console.Write("Стартирана е ");
					_c.Result(); Console.WriteLine("Команда 2\n");
				}	
				if (_command.ToLower().Contains("команда3")) 
				{
					_c.Default(); Console.Write("Стартирана е ");
					_c.Result(); Console.WriteLine("Команда 3\n");
				}	


			}while(_command.ToLower() != "изход");
		}

		public void JustTesting()
		{
			Console.WriteLine ("Стартиране на UserInput.UInput.JustTesting()");
		}
	}
}

