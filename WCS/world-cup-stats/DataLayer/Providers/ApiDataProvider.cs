using DataLayer.Interfaces;
using DataLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Providers
{
	public class ApiDataProvider : IDataProvider
	{
		private readonly HttpClient _httpClient;
		private readonly string _baseUrl = "https://worldcup-vua.nullbit.hr";

		public ApiDataProvider()
		{
			_httpClient = new HttpClient();
		}

		public async Task<List<Team>> GetTeamsAsync(string gender)
		{
			string response = await _httpClient.GetStringAsync($"{_baseUrl}/{gender}/teams/results");
			return JsonConvert.DeserializeObject<List<Team>>(response);
		}

		public async Task<List<Match>> GetMatchesAsync(string gender)
		{
			string response = await _httpClient.GetStringAsync($"{_baseUrl}/{gender}/matches");
			return JsonConvert.DeserializeObject<List<Match>>(response);
		}

		public async Task<List<Match>> GetTeamMatchesAsync(string gender, string fifaCode)
		{
			string response = await _httpClient.GetStringAsync($"{_baseUrl}/{gender}/matches/country?fifa_code={fifaCode}");
			return JsonConvert.DeserializeObject<List<Match>>(response);
		}

		public async Task<List<GroupResult>> GetGroupResultsAsync(string gender)
		{
			string response = await _httpClient.GetStringAsync($"{_baseUrl}/{gender}/teams/group_results");
			return JsonConvert.DeserializeObject<List<GroupResult>>(response);
		}
	}
}
