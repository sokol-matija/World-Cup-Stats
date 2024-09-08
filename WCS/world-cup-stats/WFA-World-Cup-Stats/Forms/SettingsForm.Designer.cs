namespace WFA_World_Cup_Stats.Forms
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblChampionship = new Label();
			lblLanguage = new Label();
			cmbChampionship = new ComboBox();
			cmbLanguage = new ComboBox();
			btnSave = new Button();
			SuspendLayout();
			// 
			// lblChampionship
			// 
			lblChampionship.AutoSize = true;
			lblChampionship.Location = new Point(55, 53);
			lblChampionship.Name = "lblChampionship";
			lblChampionship.Size = new Size(146, 30);
			lblChampionship.TabIndex = 0;
			lblChampionship.Text = "Championship";
			// 
			// lblLanguage
			// 
			lblLanguage.AutoSize = true;
			lblLanguage.Location = new Point(55, 163);
			lblLanguage.Name = "lblLanguage";
			lblLanguage.Size = new Size(104, 30);
			lblLanguage.TabIndex = 1;
			lblLanguage.Text = "Language";
			// 
			// cmbChampionship
			// 
			cmbChampionship.FormattingEnabled = true;
			cmbChampionship.Location = new Point(55, 95);
			cmbChampionship.Name = "cmbChampionship";
			cmbChampionship.Size = new Size(212, 38);
			cmbChampionship.TabIndex = 2;
			// 
			// cmbLanguage
			// 
			cmbLanguage.FormattingEnabled = true;
			cmbLanguage.Location = new Point(55, 205);
			cmbLanguage.Name = "cmbLanguage";
			cmbLanguage.Size = new Size(212, 38);
			cmbLanguage.TabIndex = 3;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(55, 292);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(212, 40);
			btnSave.TabIndex = 4;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			// 
			// SettingsForm
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(332, 391);
			Controls.Add(btnSave);
			Controls.Add(cmbLanguage);
			Controls.Add(cmbChampionship);
			Controls.Add(lblLanguage);
			Controls.Add(lblChampionship);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SettingsForm";
			Text = "Settings";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblChampionship;
		private Label lblLanguage;
		private ComboBox cmbChampionship;
		private ComboBox cmbLanguage;
		private Button btnSave;
	}
}