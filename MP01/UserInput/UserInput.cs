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
				if (_command.ToLower().Contains("яма")) 	_calc.F01.calc(_command);

				if (_command.ToLower().Contains("въгъл")) 	_calc.F02.calc(_command);

				if (_command.ToLower().Contains("иъгъл")) 	_calc.F03.calc(_command);

				if (_command.ToLower().Contains("откос")) 	_calc.F04.calc(_command);

				if (_command.ToLower().Contains("канал")) 	_calc.F05.calc(_command);

				if (_command.ToLower().Contains("помощ")||
					_command.ToLower() == "-п") 	_calc.commands();

				if (_command.ToLower().Contains("изчисти")||
					_command.ToLower() == "-и") 

				
				{
					Console.Clear();
					_c.Default();
					sayHello();
				}

			
			}while(_command.ToLower() != "изход");
		}

		public void JustTesting()
		{
			Console.WriteLine ("Стартиране на UserInput.UInput.JustTesting()");
		}
	}
}

