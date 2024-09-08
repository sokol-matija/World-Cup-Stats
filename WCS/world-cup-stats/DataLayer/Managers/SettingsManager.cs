using DataLayer.Interfaces;
using DataLayer.Models;
using DataLayer.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
	public class SettingsManager : ISettingsManager
	{
		public SettingsManager()
		{
		}

		public async Task<Settings> GetSettingsAsync()
		{
			LoggingService.Log("Attempting to get settings");
			if (File.Exists(FilePathManager.GetSettingsPath()))
			{
				string json = await File.ReadAllTextAsync(FilePathManager.GetSettingsPath());
				var settings = JsonConvert.DeserializeObject<Settings>(json);
				LoggingService.Log("Settings loaded successfully");
				return settings;
			}
			else
			{
				LoggingService.Log("Settings file not found. Creating new settings file.");
				var defaultSettings = CreateDefaultSettings();
				await SaveSettingsAsync(defaultSettings);
				return defaultSettings;
			}
		}

		public async Task SaveSettingsAsync(Settings settings)
		{
			LoggingService.Log("Saving settings");
			string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
			await File.WriteAllTextAsync(FilePathManager.GetSettingsPath(), json);
			LoggingService.Log("Settings saved successfully");
		}

		private Settings CreateDefaultSettings()
		{
			LoggingService.Log("Creating default settings");
			return new Settings
			{
				Championship = "men",
				Language = "en",
				DataSourceType = "api", // or "json", depending on your default preference
				FavoriteTeamMen = "",
				FavoriteTeamWomen = "",
				FavoritePlayers = new Dictionary<string, Dictionary<string, List<string>>>
				{
					["men"] = new Dictionary<string, List<string>>(),
					["women"] = new Dictionary<string, List<string>>()
				}
			};
		}


	}
}
