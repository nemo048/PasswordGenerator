namespace PasswordGenerator
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.generate = new System.Windows.Forms.Button();
			this.passLengthLabel = new System.Windows.Forms.Label();
			this.lengthTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.RichTextBox();
			this.numbersCheckBox = new System.Windows.Forms.CheckBox();
			this.specSymbCheckBox = new System.Windows.Forms.CheckBox();
			this.smallLettersCheckBox = new System.Windows.Forms.CheckBox();
			this.bigLettersCheckBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// generate
			// 
			this.generate.Location = new System.Drawing.Point(138, 45);
			this.generate.Name = "generate";
			this.generate.Size = new System.Drawing.Size(91, 23);
			this.generate.TabIndex = 0;
			this.generate.Text = "Generate";
			this.generate.UseVisualStyleBackColor = true;
			this.generate.Click += new System.EventHandler(this.generate_Click);
			// 
			// passLengthLabel
			// 
			this.passLengthLabel.AutoSize = true;
			this.passLengthLabel.Location = new System.Drawing.Point(8, 50);
			this.passLengthLabel.Name = "passLengthLabel";
			this.passLengthLabel.Size = new System.Drawing.Size(40, 13);
			this.passLengthLabel.TabIndex = 1;
			this.passLengthLabel.Text = "Length";
			// 
			// lengthTextBox
			// 
			this.lengthTextBox.Location = new System.Drawing.Point(54, 47);
			this.lengthTextBox.Name = "lengthTextBox";
			this.lengthTextBox.Size = new System.Drawing.Size(79, 20);
			this.lengthTextBox.TabIndex = 2;
			this.lengthTextBox.Text = "8";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordTextBox.Location = new System.Drawing.Point(9, 6);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(223, 35);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.Text = "";
			// 
			// numbersCheckBox
			// 
			this.numbersCheckBox.AutoSize = true;
			this.numbersCheckBox.Checked = true;
			this.numbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.numbersCheckBox.Location = new System.Drawing.Point(12, 73);
			this.numbersCheckBox.Name = "numbersCheckBox";
			this.numbersCheckBox.Size = new System.Drawing.Size(66, 17);
			this.numbersCheckBox.TabIndex = 4;
			this.numbersCheckBox.Text = "numbers";
			this.numbersCheckBox.UseVisualStyleBackColor = true;
			// 
			// specSymbCheckBox
			// 
			this.specSymbCheckBox.AutoSize = true;
			this.specSymbCheckBox.Checked = true;
			this.specSymbCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.specSymbCheckBox.Location = new System.Drawing.Point(12, 97);
			this.specSymbCheckBox.Name = "specSymbCheckBox";
			this.specSymbCheckBox.Size = new System.Drawing.Size(99, 17);
			this.specSymbCheckBox.TabIndex = 5;
			this.specSymbCheckBox.Text = "special symbols";
			this.specSymbCheckBox.UseVisualStyleBackColor = true;
			// 
			// smallLettersCheckBox
			// 
			this.smallLettersCheckBox.AutoSize = true;
			this.smallLettersCheckBox.Checked = true;
			this.smallLettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.smallLettersCheckBox.Location = new System.Drawing.Point(138, 73);
			this.smallLettersCheckBox.Name = "smallLettersCheckBox";
			this.smallLettersCheckBox.Size = new System.Drawing.Size(80, 17);
			this.smallLettersCheckBox.TabIndex = 6;
			this.smallLettersCheckBox.Text = "small letters";
			this.smallLettersCheckBox.UseVisualStyleBackColor = true;
			// 
			// bigLettersCheckBox
			// 
			this.bigLettersCheckBox.AutoSize = true;
			this.bigLettersCheckBox.Checked = true;
			this.bigLettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.bigLettersCheckBox.Location = new System.Drawing.Point(138, 97);
			this.bigLettersCheckBox.Name = "bigLettersCheckBox";
			this.bigLettersCheckBox.Size = new System.Drawing.Size(96, 17);
			this.bigLettersCheckBox.TabIndex = 7;
			this.bigLettersCheckBox.Text = "BIG LETTERS";
			this.bigLettersCheckBox.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 121);
			this.Controls.Add(this.bigLettersCheckBox);
			this.Controls.Add(this.smallLettersCheckBox);
			this.Controls.Add(this.specSymbCheckBox);
			this.Controls.Add(this.numbersCheckBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.lengthTextBox);
			this.Controls.Add(this.passLengthLabel);
			this.Controls.Add(this.generate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PassGen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button generate;
		private System.Windows.Forms.Label passLengthLabel;
		private System.Windows.Forms.TextBox lengthTextBox;
		private System.Windows.Forms.RichTextBox passwordTextBox;
		private System.Windows.Forms.CheckBox numbersCheckBox;
		private System.Windows.Forms.CheckBox specSymbCheckBox;
		private System.Windows.Forms.CheckBox smallLettersCheckBox;
		private System.Windows.Forms.CheckBox bigLettersCheckBox;
	}
}

