using System;
using System.Threading.Tasks;
using DataLayer.Factory;
using DataLayer.Interfaces;
using DataLayer.Managers;
using DataLayer.Models;

class Testing
{
	static async Task Main(string[] args)
	{
		Console.WriteLine("Starting DataLayer Testing Application");

		// Initialize FilePathManager
		FilePathManager.Initialize();

		// Test SettingsManager
		await TestSettingsManager();

		// Test DataProvider (both API and JSON)
		await TestDataProvider("api");
		await TestDataProvider("json");

		// Test FavoritesManager
		await TestFavoritesManager();

		// Test ImageManager
		TestImageManager();

		Console.WriteLine("Testing completed. Press any key to exit.");
		Console.ReadKey();
	}

	static async Task TestSettingsManager()
	{
		Console.WriteLine("\nTesting SettingsManager:");
		ISettingsManager settingsManager = new SettingsManager();

		// Get settings
		var settings = await settingsManager.GetSettingsAsync();
		Console.WriteLine($"Current settings: Championship={settings.Championship}, Language={settings.Language}, DataSourceType={settings.DataSourceType}");

		// Modify and save settings
		settings.Championship = "women";
		settings.Language = "hr";
		await settingsManager.SaveSettingsAsync(settings);
		Console.WriteLine("Settings saved");

		// Verify changes
		settings = await settingsManager.GetSettingsAsync();
		Console.WriteLine($"Updated settings: Championship={settings.Championship}, Language={settings.Language}, DataSourceType={settings.DataSourceType}");
	}

	static async Task TestDataProvider(string dataSourceType)
	{
		Console.WriteLine($"\nTesting {dataSourceType.ToUpper()} DataProvider:");
		IDataProvider dataProvider = DataProviderFactory.CreateDataProvider(dataSourceType);

		// Test GetTeamsAsync
		var teams = await dataProvider.GetTeamsAsync("men");
		Console.WriteLine($"Number of men's teams: {teams.Count}");

		// Test GetMatchesAsync
		var matches = await dataProvider.GetMatchesAsync("men");
		Console.WriteLine($"Number of men's matches: {matches.Count}");

		// Test GetTeamMatchesAsync
		if (teams.Count > 0)
		{
			var teamMatches = await dataProvider.GetTeamMatchesAsync("men", teams[0].FifaCode);
			Console.WriteLine($"Number of matches for {teams[0].Country}: {teamMatches.Count}");
		}

		// Test GetGroupResultsAsync
		var groupResults = await dataProvider.GetGroupResultsAsync("men");
		Console.WriteLine($"Number of group results: {groupResults.Count}");
	}

	static async Task TestFavoritesManager()
	{
		Console.WriteLine("\nTesting FavoritesManager:");
		ISettingsManager settingsManager = new SettingsManager();
		IFavoritesManager favoritesManager = new FavoritesManager(settingsManager);

		// Save favorite players
		var testPlayers = new List<string> { "Player1", "Player2", "Player3" };
		await favoritesManager.SaveFavoritePlayersAsync("men", "USA", testPlayers);
		Console.WriteLine("Favorite players saved");

		// Get favorite players
		var savedPlayers = await favoritesManager.GetFavoritePlayersAsync("men", "USA");
		Console.WriteLine($"Saved favorite players: {string.Join(", ", savedPlayers)}");
	}

	static void TestImageManager()
	{
		Console.WriteLine("\nTesting ImageManager:");
		IImageManager imageManager = new ImageManager();

		// Test GetPlayerImagePath
		string playerName = "Messi";
		string imagePath = imageManager.GetPlayerImagePath(playerName);
		Console.WriteLine($"Image path for {playerName}: {imagePath}");
	}
}