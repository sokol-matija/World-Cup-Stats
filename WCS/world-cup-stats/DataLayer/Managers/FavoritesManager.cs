using DataLayer.Interfaces;
using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
	public class FavoritesManager : IFavoritesManager
	{
		private readonly ISettingsManager _settingsManager;
		private readonly Settings _settings;

		public FavoritesManager(ISettingsManager settingsManager)
		{
			_settingsManager = settingsManager ?? throw new ArgumentNullException(nameof(settingsManager));
			_settings = settingsManager.GetSettingsAsync().GetAwaiter().GetResult();
			LoggingService.Log("FavoritesManager initialized");
		}

		public async Task<List<string>> GetFavoritePlayersAsync(string gender, string teamCode)
		{
			var settings = await _settingsManager.GetSettingsAsync();

			if (settings.FavoritePlayers.TryGetValue(gender, out var genderFavorites))
			{
				if (genderFavorites.TryGetValue(teamCode, out var teamFavorites))
				{
					return new List<string>(teamFavorites);
				}
			}

			return new List<string>();
		}

		public async Task SaveFavoritePlayersAsync(string gender, string teamCode, List<string> players)
		{
			var settings = await _settingsManager.GetSettingsAsync();

			if (!settings.FavoritePlayers.ContainsKey(gender))
			{
				settings.FavoritePlayers[gender] = new Dictionary<string, List<string>>();
			}

			settings.FavoritePlayers[gender][teamCode] = new List<string>(players);

			await _settingsManager.SaveSettingsAsync(settings);
		}
	}
}
