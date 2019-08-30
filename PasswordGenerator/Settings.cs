using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
	public sealed class Settings
	{
		public bool Numbers { get; set; }
		public bool SpecSymbols { get; set; }
		public bool SmallLetters { get; set; }
		public bool BigLetters { get; set; }
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
