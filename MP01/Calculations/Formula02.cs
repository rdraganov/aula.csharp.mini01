using System;

namespace Calculations
{
	public class Formula02
	{
		public Formula02 ()
		{
		}

		public void calc (string _input)
		{
			try{
				string[] param=_input.Split(' ');

				if (param.Length>1 && _input.ToLower().Contains("-п"))
				{
					help();
				}
				if (param.Length==4)
				{
					double result=0;
					if (runCalculations(param,out result)) {
						Console.Write("Обемът на вдлъбнатия ъгъл е ");
						Console.Write(result.ToString("N2"));
						Console.WriteLine(" м3\n");
					
					}else{
						Console.WriteLine("Има грешно въведени параметрил. С параметъра '-п' можете \nда видите синтаксиса на командата.");
					}

				}

			}catch{
			}
		}

		private bool runCalculations(string[] _param, out double _result)
		{
			try{
				Console.WriteLine("Опитвам да парсна...\n");
				double a=0; Double.TryParse(_param[1],out a);
				double b=0; Double.TryParse(_param[2],out b);
				double h=0; Double.TryParse(_param[3],out h);
				Console.WriteLine("Успях!");
				_result= a * b * h / 3;
				return true;
			}catch{
			}
			_result = 0;
			return false;
		}

		private void help()
		{
			Console.Write ("[въгъл]");
			Console.WriteLine (" - вдлъбнат ъгъл");

			Console.Write ("параметри: ");
			Console.WriteLine ("a b h\n");

			Console.Write ("a b ");
			Console.WriteLine (" - ширина и дължина");

			Console.Write ("h");
			Console.WriteLine (" - височина\n");

		}
	}
}

