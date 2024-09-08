using DataLayer.Interfaces;
using DataLayer.Managers;
using DataLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Providers
{
	public class JsonDataProvider : IDataProvider
	{
		public JsonDataProvider()
		{
		}

		public async Task<List<Team>> GetTeamsAsync(string gender)
		{
			string path = FilePathManager.GetTeamsJsonPath(gender);
			string json = await File.ReadAllTextAsync(path);
			return JsonConvert.DeserializeObject<List<Team>>(json);
		}

		public async Task<List<Match>> GetMatchesAsync(string gender)
		{
			string path = FilePathManager.GetMatchesJsonPath(gender);
			string json = await File.ReadAllTextAsync(path);
			return JsonConvert.DeserializeObject<List<Match>>(json);
		}

		public async Task<List<Match>> GetTeamMatchesAsync(string gender, string fifaCode)
		{
			var allMatches = await GetMatchesAsync(gender);
			return allMatches.FindAll(m => m.HomeTeam.Code == fifaCode || m.AwayTeam.Code == fifaCode);
		}

		public async Task<List<GroupResult>> GetGroupResultsAsync(string gender)
		{
			string path = FilePathManager.GetGroupResultsJsonPath(gender);
			string json = await File.ReadAllTextAsync(path);
			return JsonConvert.DeserializeObject<List<GroupResult>>(json);
		}
	}
}
