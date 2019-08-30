using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
	public sealed class Settings
	{
		public bool Numbers { get; }
		public bool SpecSymbols { get; }
		public bool SmallLetters { get; }
		public bool BigLetters { get; }
        public int PasswordLength { get; set; }

		public Settings(bool numbers, bool specSymbols, bool smallLetters, bool bigLetters, int passwordLength)
		{
			Numbers = numbers;
			SpecSymbols = specSymbols;
			SmallLetters = smallLetters;
			BigLetters = bigLetters;
            PasswordLength = passwordLength;
        }
	}
}
