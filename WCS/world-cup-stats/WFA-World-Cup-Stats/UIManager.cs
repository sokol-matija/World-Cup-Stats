using DataLayer.Interfaces;
using DataLayer.Managers;
using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_World_Cup_Stats.Forms;

namespace WFA_World_Cup_Stats
{
	public class UIManager
	{
		private readonly Form _form;
		private readonly ISettingsManager settingsManager = new SettingsManager();

		public UIManager(Form form)
		{
			_form = form;
			LoggingService.Log("UIManager initialized");
		}

		public async Task ShowLogFormAsync()
		{
			await InvokeAsync(() =>
			{
				var logForm = new WFALogForm();
				logForm.Show();
			});
		}

		public async Task EnableUIAsync()
		{
			await InvokeAsync(() => _form.Enabled = true);
		}

		public async Task<bool> ShowSettingsFormAsync(Settings settings)
		{
			return await InvokeAsync(() =>
			{
				using (var settingsForm = new SettingsForm(settings, settingsManager))
				{
					return settingsForm.ShowDialog() == DialogResult.OK;
				}
			});
		}

		public bool ConfirmApplicationClose()
		{
			return MessageBox.Show(
				"Are you sure you want to close the application?",
				"Confirm Close",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2) == DialogResult.Yes;
		}

		public async Task MoveToFavoritesAsync()
		{
			// Implement move to favorites logic
		}

		public Task<T> InvokeAsync<T>(Func<T> func)
		{
			return Task.Factory.FromAsync(_form.BeginInvoke(new Func<T>(func)), ar => (T)_form.EndInvoke(ar));
		}

		public Task InvokeAsync(Action action)
		{
			return Task.Factory.FromAsync(_form.BeginInvoke(new MethodInvoker(action)), _form.EndInvoke);
		}
	}
}
