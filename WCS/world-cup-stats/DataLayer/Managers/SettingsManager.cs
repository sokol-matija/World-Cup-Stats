using DataLayer.Interfaces;
using DataLayer.Models;
using DataLayer.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
	public class SettingsManager : ISettingsManager
	{
		public bool IsFirstRun { get; private set; }

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
				IsFirstRun = false;
				return settings;
			}
			else
			{
				LoggingService.Log("Settings file not found. Creating default settings.");
				var defaultSettings = CreateDefaultSettings();
				await SaveSettingsAsync(defaultSettings);
				IsFirstRun = true;
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
				DataSourceType = "api",
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