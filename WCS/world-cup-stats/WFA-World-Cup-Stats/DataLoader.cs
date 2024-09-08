using DataLayer.Interfaces;
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
	public class DataLoader
	{
		private readonly IDataProvider _dataProvider;
		private readonly ISettingsManager _settingsManager;
		private readonly IFavoritesManager _favoritesManager;
		private readonly UIManager _uiManager;

		public DataLoader(IDataProvider dataProvider, ISettingsManager settingsManager, IFavoritesManager favoritesManager, UIManager uIManager)
		{
			_dataProvider = dataProvider;
			_settingsManager = settingsManager;
			_favoritesManager = favoritesManager;
			_uiManager = uIManager;
			LoggingService.Log("DataLoader initialized");
		}

		public async Task LoadInitialDataAsync()
		{
			
			await ApplySettingsAsync();
		}

		public async Task ApplySettingsAsync()
		{
			var settings = await _settingsManager.GetSettingsAsync();
			await LoadChampionshipDataAsync(settings.Championship);
			var favoriteTeam = settings.Championship == "men" ? settings.FavoriteTeamMen : settings.FavoriteTeamWomen;
			if (!string.IsNullOrEmpty(favoriteTeam))
			{
				await LoadPlayerDetailsAsync(favoriteTeam, settings.Championship);
			}
		}

		public async Task LoadChampionshipDataAsync(string championship)
		{
			var teams = await _dataProvider.GetTeamsAsync(championship);
			var matches = await _dataProvider.GetMatchesAsync(championship);
			// Update UI with teams and matches data
		}

		public async Task LoadPlayerDetailsAsync(string fifaCode, string championship)
		{
			var matches = await _dataProvider.GetTeamMatchesAsync(championship, fifaCode);
			var players = ExtractPlayersFromMatches(matches);
			var favoritePlayers = await _favoritesManager.GetFavoritePlayersAsync(championship, fifaCode);
			// Update UI with player details
		}

		private List<Player> ExtractPlayersFromMatches(List<Match> matches)
		{
			// Extract unique players from matches
			return new List<Player>();
		}
	}
}
