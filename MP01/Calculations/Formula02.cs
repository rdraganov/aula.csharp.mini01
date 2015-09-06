using System;

namespace Calculations
{
	/// <summary>
	/// Клас за изчисляване на Formula02.
	/// </summary>
	public class Formula02
	{
		Colors.ForCLI _cl = new Colors.ForCLI();
		public Formula02 ()
		{
		}

		/// <summary>
		/// Изчислителен метод за Formula 01
		/// </summary>
		/// <param name="_input">Входен стринг, зададен от потребителя.</param>
		public void calc (string _input)
		{
			try{
				string[] param=_input.Split(' ');

				if (param.Length>1 && _input.ToLower().Contains("-п"))
				{
					help();
				}
				double result=0;
				if (runCalculations(param,out result)) {
					_cl.Default(); Console.Write("Обемът на вдлъбнатия ъгъл е ");
					_cl.Result();  Console.Write(result.ToString("N2"));
					_cl.Command(); Console.WriteLine(" м3\n");
				
				}else{
					_cl.Default();  Console.WriteLine("Има грешно въведени параметрил. С параметъра '-п' можете \nда видите синтаксиса на командата.");
				}


			}catch{
			}
		}


		/// <summary>
		/// Вътрешен модул за изчисления
		/// </summary>
		/// <returns><c>true</c>, if calculations was run, <c>false</c> otherwise.</returns>
		/// <param name="_param">Масив съдържащ параметрите на командата на потребителя.</param>
		/// <param name="_result">Резултат от изчисленията</param>
		private bool runCalculations(string[] _param, out double _result)
		{
			try{
				double a=0; Double.TryParse(_param[1],out a);
				double b=0; Double.TryParse(_param[2],out b);
				double h=0; Double.TryParse(_param[3],out h);
				_result= a * b * h / 3;
				return true;
			}catch{
			}
			_result = 0;
			return false;
		}

		/// <summary>
		/// Помощ за командата
		/// </summary>
		private void help()
		{
			_cl.Result(); Console.Write ("[въгъл]");
			_cl.Command(); Console.WriteLine (" - вдлъбнат ъгъл");

			_cl.Result(); Console.Write ("параметри: ");
			_cl.Command(); Console.WriteLine ("a b h\n");

			_cl.Result(); Console.Write ("a b ");
			_cl.Command(); Console.WriteLine (" - ширина и дължина");

			_cl.Result(); Console.Write ("h");
			_cl.Command(); Console.WriteLine (" - височина\n");

		}
	}
}

