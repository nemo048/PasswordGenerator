using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
	public partial class MainForm : Form
	{
		private Settings m_settings;

		public MainForm()
		{
			InitializeComponent();
		}

		private void generate_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            int passwordLength = int.Parse(lengthTextBox.Text);
            m_settings = new Settings(
                numbersCheckBox.Checked, 
                specSymbCheckBox.Checked, 
                smallLettersCheckBox.Checked, 
                bigLettersCheckBox.Checked, 
                passwordLength);
            GeneratePassword();
        }

        private void GeneratePassword()
        {
            passwordTextBox.Text = Generator.GetPassword(m_settings);
        }

        private void Settings_Validated(object sender, EventArgs e)
        {
            m_settings.PasswordLength = int.Parse(lengthTextBox.Text);
            m_settings.Numbers = numbersCheckBox.Checked;
            m_settings.SpecSymbols = specSymbCheckBox.Checked;
            m_settings.SmallLetters = smallLettersCheckBox.Checked;
            m_settings.BigLetters = bigLettersCheckBox.Checked;
        }
    }
}
