using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_World_Cup_Stats.Forms
{
	public partial class WFALogForm : Form
	{
		private ListBox listBoxLogs;

		public WFALogForm()
		{
			InitializeComponent();
			InitializeLogListBox();
			LoggingService.LogAdded += OnLogAdded;

			this.Size = new Size(600, 600);
			this.Text = "Log Window";
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void InitializeLogListBox()
		{
			listBoxLogs = new ListBox
			{
				Dock = DockStyle.Fill
			};
			this.Controls.Add(listBoxLogs);

			foreach (var log in LoggingService.GetLogs())
			{
				listBoxLogs.Items.Add($"{log.Timestamp}: {log.Message}");
			}
		}

		private void OnLogAdded(object sender, LogEntry e)
		{
			if (listBoxLogs.InvokeRequired)
			{
				listBoxLogs.Invoke(new Action<object, LogEntry>(OnLogAdded), sender, e);
				return;
			}

			listBoxLogs.Items.Add($"{e.Timestamp}: {e.Message}");
			listBoxLogs.TopIndex = listBoxLogs.Items.Count - 1;
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			LoggingService.LogAdded -= OnLogAdded;
			base.OnFormClosing(e);
		}
	}
}
