using DataLayer.Interfaces;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
	public class ImageManager : IImageManager
	{
		public string GetPlayerImagePath(string playerName)
		{
			LoggingService.Log($"Getting image path for player: {playerName}");
			return FilePathManager.GetPlayerImagePath(playerName);
		}
	}
}
