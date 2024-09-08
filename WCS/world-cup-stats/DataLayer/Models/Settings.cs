using Newtonsoft.Json;

namespace DataLayer.Models
{
	public class Settings
	{
		[JsonProperty("DataSourceType")]
		public string DataSourceType { get; set; } = "api";

		[JsonProperty("Championship")]
		public string Championship { get; set; } = "men";

		[JsonProperty("Language")]
		public string Language { get; set; } = "en";

		[JsonProperty("FavoriteTeamMen")]
		public string FavoriteTeamMen { get; set; }

		[JsonProperty("FavoriteTeamWomen")]
		public string FavoriteTeamWomen { get; set; }

		[JsonProperty("FavoritePlayers")]
		public Dictionary<string, Dictionary<string, List<string>>> FavoritePlayers { get; set; }
			= new Dictionary<string, Dictionary<string, List<string>>>
			{
				["men"] = new Dictionary<string, List<string>>(),
				["women"] = new Dictionary<string, List<string>>()
			};
	}
}
