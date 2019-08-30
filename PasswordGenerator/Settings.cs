using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
	class Settings
	{
		public bool Numbers { get; private set; }
		public bool SpecSymbols { get; private set; }
		public bool SmallLetters { get; private set; }
		public bool BigLetters { get; private set; }

		public Settings(bool numbers, bool specSymbols, bool smallLetters, bool bigLetters)
		{
			Numbers = numbers;
			SpecSymbols = specSymbols;
			SmallLetters = smallLetters;
			BigLetters = bigLetters;
		}
	}
}
