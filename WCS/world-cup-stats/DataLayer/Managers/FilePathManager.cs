using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
	public static class FilePathManager
	{
		private static string _assetsPath;

		static FilePathManager()
		{
			Initialize();
		}


		public static void Initialize()
		{
			LoggingService.Log("Initializing FilePathManager");
			string solutionDirectory = FindSolutionDirectory();
			_assetsPath = Path.Combine(solutionDirectory, "DataLayer", "Assets");
			LoggingService.Log($"Assets directory: {_assetsPath}");
			if (!Directory.Exists(_assetsPath))
			{
				LoggingService.Log("Assets directory not found");
				throw new DirectoryNotFoundException($"Assets directory not found at: {_assetsPath}");
			}
		}

		private static string FindSolutionDirectory()
		{
			string currentDir = AppDomain.CurrentDomain.BaseDirectory;
			while (currentDir != null)
			{
				if (File.Exists(Path.Combine(currentDir, "world-cup-stats.sln")))
				{
					return currentDir;
				}
				currentDir = Directory.GetParent(currentDir)?.FullName;
			}
			throw new DirectoryNotFoundException("Solution directory not found.");
		}

		public static string GetSettingsPath() => Path.Combine(_assetsPath, "settings.json");

		public static string GetTeamsJsonPath(string gender) => Path.Combine(_assetsPath, gender, "teams.json");

		public static string GetMatchesJsonPath(string gender) => Path.Combine(_assetsPath, gender, "matches.json");

		public static string GetGroupResultsJsonPath(string gender) => Path.Combine(_assetsPath, gender, "group_results.json");

		public static string GetPlayerImagePath(string playerName)
		{
			string imagePath = Path.Combine(_assetsPath, "Images", $"{playerName}.png");
			return File.Exists(imagePath) ? imagePath : Path.Combine(_assetsPath, "images", "default_player.jpg");
		}
	}
}
