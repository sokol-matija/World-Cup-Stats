using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
	public interface IFavoritesManager
	{
		Task<List<string>> GetFavoritePlayersAsync(string gender, string teamCode);
		Task SaveFavoritePlayersAsync(string gender, string teamCode, List<string> players);
	}
}
