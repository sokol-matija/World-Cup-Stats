using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
	public interface IDataProvider
	{
		Task<List<Team>> GetTeamsAsync(string gender);
		Task<List<Match>> GetMatchesAsync(string gender);
		Task<List<Match>> GetTeamMatchesAsync(string gender, string fifaCode);
		Task<List<GroupResult>> GetGroupResultsAsync(string gender);
	}
}
