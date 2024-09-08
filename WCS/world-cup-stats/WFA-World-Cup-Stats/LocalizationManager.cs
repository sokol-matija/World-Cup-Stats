using Microsoft.VisualBasic;
using System.Globalization;
using WFA_World_Cup_Stats;
using WFA_World_Cup_Stats.Controls;

namespace WFA_World_Cup_Stats
{
	public class LocalizationManager
	{
		public void ChangeLanguage(string language)
		{
			CultureInfo culture;
			if (language == "hr" || language == "Croatian" || language == "Hrvatski")
			{
				culture = new CultureInfo("hr-HR");
			}
			else
			{
				culture = new CultureInfo("en-US");
			}

			Thread.CurrentThread.CurrentUICulture = culture;
			Thread.CurrentThread.CurrentCulture = culture;
		}

		public void ApplyLocalization(MainForm form)
		{
			form.Text = Strings.MainFormTitle;

			LocalizeMenuItems(form);
			LocalizeLabels(form);
			LocalizeButtons(form);

			LocalizePlayerControls(form.pnlAllPlayers);
			LocalizePlayerControls(form.pnlFavoritePlayers);
		}

		private void LocalizeMenuItems(MainForm form)
		{
			form.mnuSettings.Text = Strings.Settings;
			form.mnuPrint.Text = Strings.Print;
			form.mnuPrintStatistics.Text = Strings.PrintStatistics;
		}

		private void LocalizeLabels(MainForm form)
		{
			form.lblTopScorers.Text = Strings.TopScorers;
			form.lblYellowCards.Text = Strings.YellowCards;
			form.lblAllPlayers.Text = Strings.AllPlayers;
			form.lblFavoritePlayers.Text = Strings.FavoritePlayers;
			form.lblMatches.Text = Strings.Matches;
			form.lblChooseTeam.Text = Strings.ChooseTeam;
		}

		private void LocalizeButtons(MainForm form)
		{
			form.btnMoveToFavorites.Text = Strings.MoveToFavorites;
		}

		private void LocalizePlayerControls(Panel panel)
		{
			foreach (Control control in panel.Controls)
			{
				if (control is PlayerControl playerControl)
				{
					playerControl.ApplyLocalization();
				}
			}
		}
	}
}
