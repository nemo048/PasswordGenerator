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
    }
}
