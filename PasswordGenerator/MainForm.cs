using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
	public partial class MainForm : Form
	{
		private Settings settings;

		public MainForm()
		{
			InitializeComponent();
		}

		private void generate_Click(object sender, EventArgs e)
		{
			int passwordLength = int.Parse(lengthTextBox.Text);
			settings = new Settings(numbersCheckBox.Checked, specSymbCheckBox.Checked, smallLettersCheckBox.Checked, bigLettersCheckBox.Checked);
			passwordTextBox.Text = Generator.GetPassword(settings, passwordLength);
		}
	}
}
