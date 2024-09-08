using DataLayer.Interfaces;
using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Windows.Forms;

namespace WFA_World_Cup_Stats.Forms
{
	public partial class SettingsForm : Form
	{
		private readonly ISettingsManager _settingsManager;
		private Settings _currentSettings;

		public SettingsForm(Settings settings, ISettingsManager settingsManager)
		{
			InitializeComponent();
			_currentSettings = settings;
			_settingsManager = settingsManager;
			LoadSettings();
		}

		private async void LoadSettings()
		{
			cmbChampionship.SelectedItem = _currentSettings.Championship;
			LoggingService.Log("Settings loaded in combobox");
			LoggingService.Log(_currentSettings.Language);
			LoggingService.Log(_currentSettings.Championship);
			cmbLanguage.SelectedItem = _currentSettings.Language;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Update settings based on UI controls
			_currentSettings.Championship = cmbChampionship.SelectedItem.ToString();
			_currentSettings.Language = cmbLanguage.SelectedItem.ToString();
			// Update more settings as needed

			SaveSettings();
		}

		private async void SaveSettings()
		{
			await _settingsManager.SaveSettingsAsync(_currentSettings);
			DialogResult = DialogResult.OK;
			Close();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			// Populate ComboBoxes
			cmbChampionship.Items.AddRange(new object[] { "men", "women" });
			cmbLanguage.Items.AddRange(new object[] { "en", "hr" });
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				SaveSettings();
				return true;
			}
			else if (keyData == Keys.Escape)
			{
				DialogResult = DialogResult.Cancel;
				Close();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}