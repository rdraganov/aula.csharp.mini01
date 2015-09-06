using System;

namespace Calculations
{
	/// <summary>
	/// Клас за изчисление на Formula04.
	/// </summary>
	public class Formula04
	{
				
		private Colors.ForCLI _c = new Colors.ForCLI();
		public Formula04 () //Формула за обикновена строиелна яма
		{
		}

		/// <summary>
		/// Метод за изчисление на Formula 04
		/// </summary>
		/// <param name="_userInput">Входна команда от потребителя</param>
		public void calc(string _userInput)
		{
			try{
				string[] param=_userInput.Split(' ');

				if (param.Length>1 && _userInput.Contains("-п"))
				{
					//Помощ
					help();

				}
				if (param.Length>1 && !_userInput.Contains("-п"))
				{
					//Изчсления
					double _result=0;
					if (runCalculations(param,out _result))
					{
						_c.Default(); Console.Write("Обемът на откоса е: ");
						_c.Result(); Console.Write(_result.ToString("N2"));
						_c.Default(); Console.WriteLine(" м3\n");
					}else{
						_c.Default(); Console.WriteLine("Има грешно въведени параметри. Можете да проверите синтаксиса с параметъра '-п'\n");
					}
				}


			}catch{
			}
		}

		/// <summary>
		/// Вътрешен метод за изчисление на Formula04
		/// </summary>
		/// <returns><c>true</c>, if calculations was run, <c>false</c> otherwise.</returns>
		/// <param name="param">Масив с елементите на потребителската команда.</param>
		/// <param name="_result">Резултат от изчисленията.</param>
		private bool runCalculations(string[] param, out double _result)
		{
			try{
				double _a1=0, _b1=0, _a2=0, _b2=0, _h=0;
				//param[0] == име на командата
				Double.TryParse(param[1], out _a1);
				Double.TryParse(param[2], out _b1);
				//Double.TryParse(param[3], out _a2);
				//Double.TryParse(param[4], out _b2);
				Double.TryParse(param[3], out _h);

				double F1 = _a1*_b1, F2 = _a2*_b2;
				_result = _h*(F1+F2)/2;

				return true;
			}catch{

			}
			_result=0;
			return false;
		}

		/// <summary>
		/// Помощ за командата
		/// </summary>

		private void help ()
		{
			_c.Result(); Console.Write("[откос]");
			_c.Default(); Console.WriteLine(" - команда за пресмятане обем на страничен откос");

			_c.Command(); Console.Write("параметри: ");
			_c.Default(); Console.WriteLine(" a1 b1 h\n");

			_c.Command(); Console.Write("a1 b1:");
			_c.Default(); Console.WriteLine(" - ширина и дължина на откоса в план");

			_c.Command(); Console.Write("h: ");
			_c.Default(); Console.WriteLine(" - височина на изкопа\n");
		}
				
	}
}

