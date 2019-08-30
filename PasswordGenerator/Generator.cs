using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
	static class Generator
	{
		private static Random Random = new Random();
		private static Array SymbolToGenStates = Enum.GetValues(typeof(SymbolToGen));
		private static Array LetterToGenStates = Enum.GetValues(typeof(LetterToGen));

		public static string GetPassword(Settings settings, char startAlphabet = 'a', char endAlphabet = 'z', string specialSymbols = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`~")
		{
			if(IsAllSettingsNull(settings))
			{
				MessageBox.Show("Мы не можем создать Ваш пароль из ничего. Пожалуйста, выберите хотя бы что-то!", "Что-то пошло не так", MessageBoxButtons.OK);
				return string.Empty;
			}

			StringBuilder password = new StringBuilder();

			while(password.Length < settings.PasswordLength)
			{
				SymbolToGen symbolToGen = (SymbolToGen)SymbolToGenStates.GetValue(Random.Next(SymbolToGenStates.Length));
				if (symbolToGen == SymbolToGen.LETTER && (settings.BigLetters || settings.SmallLetters))
				{ 
					char letter = GetSymbol(startAlphabet, endAlphabet);
					LetterToGen letterToGen = (LetterToGen)LetterToGenStates.GetValue(Random.Next(LetterToGenStates.Length));
					if (letterToGen == LetterToGen.BIG && settings.BigLetters)
					{
						password.Append(letter.ToString().ToUpper());
					}
					else if(letterToGen == LetterToGen.SMALL && settings.SmallLetters)
					{
						password.Append(letter);
					}
				}
				else if(symbolToGen == SymbolToGen.NUMBER && settings.Numbers)
				{
					password.Append(GetSymbol('0', '9'));
				}
				else if(symbolToGen == SymbolToGen.SPECIAL_SYMBOL && settings.SpecSymbols)
				{
					password.Append(GetSymbol(specialSymbols));
				}
			}

			return password.ToString();
		}

		public static bool IsAllSettingsNull(Settings settings)
		{
			return !settings.Numbers && !settings.SpecSymbols && !settings.SmallLetters && !settings.BigLetters;
		}

		private static char GetSymbol(char startChar, char endChar)
		{
			return (char)Random.Next(startChar, endChar + 1);
		}

		private static char GetSymbol(string symbols)
		{
			return symbols[Random.Next(symbols.Length)];
		}

		enum SymbolToGen
		{
			LETTER,
			NUMBER,
			SPECIAL_SYMBOL
		}

		enum LetterToGen
		{
			BIG,
			SMALL
		}
	}
}
