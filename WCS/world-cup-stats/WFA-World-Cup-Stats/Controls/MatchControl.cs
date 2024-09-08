using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_World_Cup_Stats.Controls
{
	public partial class MatchControl : UserControl
	{
		public string HomeTeam { get; private set; }
		public string AwayTeam { get; private set; }
		public string Attendance { get; private set; }

		public MatchControl(Match match)
		{
			InitializeComponent();
			HomeTeam = match.HomeTeamCountry;
			AwayTeam = match.AwayTeamCountry;
			Attendance = match.Attendance;

			lblTeams.Text = $"{HomeTeam} vs {AwayTeam}";
			lblScore.Text = $"{match.HomeTeam.Goals} - {match.AwayTeam.Goals}";
			lblAttendance.Text = $"Attendance: {Attendance}";
			lblLocation.Text = $"Location: {match.Location}";
		}
	}
}
