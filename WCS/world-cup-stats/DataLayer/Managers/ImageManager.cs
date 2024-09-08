using DataLayer.Interfaces;
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
			return FilePathManager.GetPlayerImagePath(playerName);
		}
	}
}
